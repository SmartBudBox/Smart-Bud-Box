<?php

class Core extends DB {
    public $box_id = FALSE;
    public $box = FALSE;
    public $settings = FALSE;
    
    function __construct() {
        parent::__construct();
        
        $this->get_box_id();
		$this->read_host_transmissions();
    }

    function get_box_id() {
        if (isset($_GET["box"])) {
            $this->box_id = $_GET["box"];
            setcookie("box", $this->box_id, time() + (86400 * 30), "/");
        } 
        elseif (isset($_COOKIE["box"])) {
            $this->box_id = $_COOKIE["box"];
        } 
        elseif (isset($Main -> boxes[0])) {
            $this->box_id = $Main -> boxes[0]["id"];
            setcookie("box", $box_id, time() + (86400 * 30), "/");
        } 
        else {
        	$this->set_limit(array("0" => "1"));
        	$box = $this->get("boxes");
			if (isset($box["id"])) {
				$this->box_id = $box["id"];
			} else {
				$this->box_id = false;
			}
            
        }
        
        
        $this->box = $this->get("boxes", array("id" => $this->box_id));

        
        return;
    }    
    
	/**
	 * creates a transmission
	 * 
	 * @param string $from where has created the job
	 * @param string $to who should get it
	 * @param string $validity_from  mysql dateime when it should be executed
	 */
    function create_transmisson($from, $to, $command, $validity_from=false) {
        $command_json = json_encode($command);
       
       // check if transmission already exist 
       $data = array(
        "sender" => $from, 
        "recipient" => $to, 
        "data" => $command_json
       );
       
       if ($validity_from) {
         $data["validity_from"] = $validity_from;
       }
       
       $check = $this->get("_transmissions", $data);
       
       // if already exist return
       if (isset($check[0])) {
            return;   
       }
       
        // otherwise create data array for insert
        $data = array(
         "sender" => $from, 
         "recipient" => $to, 
         "data" => $command_json
        );
       
        // create message log and put validity_from into data array if isset
       if ($validity_from) {
         $data["validity_from"] = $validity_from;
         $command_json = $command_json . " @" . $validity_from;  
       } 
       else {
           $data["validity_from"] = $this->mysql_datetime();
       }
       
       //change!!!
       $this->create_message_log($command_json); 
       
       //submit to database
       $insert = $this->insert("_transmissions", $data);

       return $insert;
    }

    function create_message_log($message, $type="info") 
    {
        $data = array(
           "box" => $this->box["id"],
           "message" => $message,
           "type" => $type  
        );
       return $this->insert("messages", $data);
    }
    
    function create_error($message, $type, $box=false) 
    {
    	if ($box) {
    		$this->box["id"] = $box;
    	}
    	
        $data = array(
           "box" => $this->box["id"],
           "message" => $message,
           "type" => "danger",
           "error" => "1",
           "error_type" => $type
        );
       return $this->insert("messages", $data);
    }
    
    function mysql_datetime($timestamp=false) {
        if ($timestamp) {
            $return = date('Y-m-d H:i:s', $timestamp);
        } else {
            $return = date('Y-m-d H:i:s');
        }
        return $return ;
    }
	
	function create_watering_job() {
		$check_tank_time = 20; // 20 secound after watering check tank
		
		// if more than 1 pump repetas create more jobs
    	if ($this->box["pump_repeats"] > 1) {
            $x = 0;
            
            while ($x < $this->box["pump_repeats"]) {
                $validity_from = $this->mysql_datetime(time()+($x * $this->box["pump_repeats_delay"]));
                
                $data = array();
                $data["command"] = "watering";
                $data["value"] = $this->box["pump_runtime"];
            
                $return = $this->create_transmisson("host", $this->box["id"], $data, $validity_from); 
             
                $x++;   
            }      
        } 
        else {
            $data = array();
            $data["command"] = "watering";
            $data["value"] = $this->box["pump_runtime"];
        
            $this->create_transmisson("host", $this->box["id"], $data); 
        }
		
		//create job for check tank after watering + $check_tank_time
		if (!isset($validity_from)) {
			$validity_from = $this->mysql_datetime(time()+$check_tank_time);
		}
		
		$data = array();
        $data["command"] = "check_tank_empty";

        $return = $this->create_transmisson($this->box["id"], "host", $data, $validity_from); 
            
		
		return $return;
    }

    /**
	 * Read transmission for the host
	 * 
	 * @return 
	 */
    function read_host_transmissions() {
        $transmissons = $this->get("_transmissions", "`recipient` = 'host' AND `validity_from` < '".$this->mysql_datetime()."'");
		
		if (!$transmissons) { return; }
		
		if (isset($transmissons["id"])) {
			$new = $transmissons;
			unset($transmissons);
			$transmissons[0] = $new;
			unset($new);
		}

		foreach ($transmissons as $transmission) {
			$data = json_decode($transmission["data"], true);
			switch($data["command"]) {
				case 'check_tank_empty':
					
					$this->set_limit(array("0" => "1"));
					$this->set_order(array("id" => "DESC"));
					$sensor_data = $this->get("logs_sensors", array("box" => $transmission["sender"]));
					
					$box_data = $this->get("boxes", array("id" => $transmission["sender"]));
					
					if ($sensor_data["soil"] < $box_data["soil_is_wet"]) {
						$this->create_error("Der Wassertank ist leer, bitte nach tanken.", "watering", $transmission["sender"]);
					}
					break;
			}
			
			$this->delete("_transmissions", array("id" => $transmission["id"]));
		}
		
    }
	
	/**
	 * check for valid plans and execute them
	 */
	function execute_plans() {
		$plans = $this->get("plans", array("box" => $this->box["id"], "active" => "1"));
		
		if (!$plans) { return; }
		
		if (isset($plans["id"])) {
			$new = array();
			$new[0] = $plans;
			$plans = $new;
			unset($new);
		}
		
		foreach ($plans as $plan) {
			// valid?
			if ($plan["last_execution"] != '0000-00-00 00:00:00') {
				$timestamp = strtotime($plan["last_execution"]);
				$timestamp = time()-$timestamp;
				if ($timestamp < $plan["plan_interval"]) {
					continue;
				}
			}
			
			// deactive plan, because if theres an error it wont happend again in a error loop (-1)
			// or let it deactive if theres no interval for it and it was executed (0)
			$this->update("plans", array("active" => "-1"), array("id" => $plan["id"]));
			
			// get latest sensor data
			$this->set_limit(array("0" => "1"));
			$this->set_order(array("id" => "DESC"));
			$sensor = $this->get("logs_sensors", array("box" => $this->box["id"]));
			
			// get latest pump runtime as days like 1.54 days
			$this->set_limit(array("0" => "1"));
			$this->set_order(array("id" => "DESC"));
			$pump = $this->get("logs_pump", array("box" => $this->box["id"]));
			$pump["unixtime"] = strtotime($pump["time"]);
			$pump["time_days"] = time()-$pump["unixtime"];
			$pump["time_days"] = $pump["time_days"] / 60 / 60 / 24;
        	$pump["time_days"] = round($pump["time_days"]);
			
			
			// get errors if there is one
			$this->set_limit(array("0" => "1"));
			$this->set_order(array("id" => "DESC"));
			$error = $this->get("messages", array("box" => $this->box["id"], "error" => "1"));
			if(isset($error["id"])) {
				$error = "1";
			} else {
				$error = "0";
			}
			
			// if theres a time, convert it into unix timestamp with strtotime
			if (preg_match('/TIME [<>=)] ([0-9:. ]*)/', $plan["plan_condition"], $time_replacement)) {
				$plan["plan_condition"] = preg_replace('/TIME ([<>=)]) [0-9:. ]*/', "TIME $1 ".strtotime($time_replacement[1])." ", $plan["plan_condition"]);
			}

			// replace with parameters
			// LIGHT, TEMP, HUMI, SOIL, TIME, ERROR WATERING_LAST = < > AND, OR
			$keywords = array();
			$keywords[0] = '/LIGHT/';
			$keywords[1] = '/TEMP/';
			$keywords[2] = '/HUMI/';
			$keywords[3] = '/SOIL/';
			$keywords[4] = '/TIME/';
			$keywords[5] = '/AND/';
			$keywords[6] = '/ OR/';
			$keywords[7] = '/=/';
			$keywords[8] = '/ERROR/';
			$keywords[9] = '/WATERING_LAST/';
			
			$replacements = array();
			$replacements[0] = $this->box["status_light"];
			$replacements[1] = $sensor["temp"];
			$replacements[2] = $sensor["humi"];
			$replacements[3] = $sensor["soil"];
			$replacements[4] = time();
			$replacements[5] = "&&";
			$replacements[6] = "||";
			$replacements[7] = "==";
			$replacements[8] = $error;
			$replacements[9] = $pump["time_days"];
			
			$plan["plan_condition"] =  preg_replace($keywords, $replacements, $plan["plan_condition"]);
			// string into if
			$eval_check = eval("if (".$plan["plan_condition"].") { return TRUE; } else { return FALSE;}");
			if ($eval_check) {
				// explode the jobs
				$jobs = explode(",", $plan["job"]);
				foreach ($jobs as $job) {
					$job = trim($job);	
					
					switch ($job) {
						case 'light_on':
							$this->update("boxes", array("light" => "1"), array("id" => $this->box["id"]));
							break;
						case 'light_off':
							$this->update("boxes", array("light" => "0"), array("id" => $this->box["id"]));
							break;
						case 'exhaust_on':
							$this->update("boxes", array("exhaust" => "1"), array("id" => $this->box["id"]));
							break;
						case 'exhaust_off':
							$this->update("boxes", array("exhaust" => "0"), array("id" => $this->box["id"]));
							break;
						case 'fan_on':
							$this->update("boxes", array("fan" => "1"), array("id" => $this->box["id"]));
							break;
						case 'fan_off':
							$this->update("boxes", array("fan" => "0"), array("id" => $this->box["id"]));
							break;
						case 'watering':
							// check if empty tank, if not watering
							$this->set_limit(array("0" => "1"));
							$tanky_empty = $this->get("messages", array("error" => "1", "error_type" => "watering", "box" => $this->box["id"])); 
							
							if (!$tanky_empty) {
								$this->create_watering_job();
							}
							break;
						case 'mail':
							// get name or id and send mail
							if (empty($this->box["alias"])) {
								$box_name = $this->box["name"];
							} else {
								$box_name = $this->box["alias"];
							}
							mail(MAIL_ADRESS , "SBB Plan ".$plan["name"]." on ".$box_name, "Automated generated mail because condition on plan (".$plan["name"].") is true (". $plan["plan_condition"].")");
							break;
					}
				}
				
				//set last_execution to current
				$this->update("plans", array("last_execution" => $this->mysql_datetime()), array("id" => $plan["id"]));
				
				//send message to console that plan was executed
				$this->create_message_log("Plan executed: ".$plan["name"]);
				
			}

			// acitvate plan again if theres a plan_interval
			if ($plan["plan_interval"] != "-1") {
				$this->update("plans", array("active" => "1"), array("id" => $plan["id"]));	
			} else {
				$this->update("plans", array("active" => "0"), array("id" => $plan["id"]));	
			}
			
		}
		
		return TRUE;
	}
}

?>