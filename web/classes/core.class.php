<?php

class Core extends DB {
    public $box_id = FALSE;
    public $box = FALSE;
    public $settings = FALSE;
    
    function __construct() {
        parent::__construct();
        
        $this->get_box_id();
    }

    function get_box_id() {
        if (isset($_GET["box"])) {
            $this->box_id = $_GET["box"];
            setcookie("box", $this->box_id, time() + (86400 * 30), "/");
        } elseif (isset($_COOKIE["box"])) {
            $this->box_id = $_COOKIE["box"];
        } elseif (isset($Main -> boxes[0])) {
            $this->box_id = $Main -> boxes[0]["id"];
            setcookie("box", $box_id, time() + (86400 * 30), "/");
        } else {
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
       $this->insert("messages", $data);
    }
    
    function create_error($message) 
    {
        return;
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
    	if ($this->box["pump_repeats"] > 1) {
            $x = 0;
            
            while ($x < $this->box["pump_repeats"]) {
                $validity_from = $this->mysql_datetime(time()+($x * $this->box["pump_repeats_delay"]));
                
                $data = array();
                $data["command"] = "watering";
                $data["value"] = $this->box["pump_runtime"];
            
                $return = $this->create_transmisson("host", $this->box_id, $data, $validity_from); 
                
                unset($validity_from);
             
                $x++;   
            }
			
			return $return;
            
        } 
        else {
            $data = array();
            $data["command"] = "watering";
            $data["value"] = $this->box["pump_runtime"];
        
            return $this->create_transmisson("host", $this->box_id, $data); 
            
        }
    }
	
	function execute_plans() {
		$plans = $this->get("plans", array("box" => $this->box["id"]));
		if (!$plans) { return; }
		
		foreach ($plans as $plan) {
			// valid?
			if ($plan["last_execution"] != "0000-00-00 00:00:00") {
				$timestamp = strtotime($mysqltime);
				$timestamp = time()-$timestamp;
				if ($timestamp < $plan["plan_interval"]) {
					return;
				}
			}
			// get latest sensor data
			$this->set_limit(array("0" => "1"));
			$this->set_order(array("id" => "DESC"));
			$sensor = $this->get("logs_sensors", array("box" => $this->box["id"]));
			// replace with parameters
			// LIGHT, TEMP, HUMI, SOIL, TIME = < > AND, OR
			$keywords = array();
			$keywords[0] = '/LIGHT/';
			$keywords[1] = '/TEMP/';
			$keywords[2] = '/HUMI/';
			$keywords[3] = '/SOIL/';
			$keywords[4] = '/TIME/';
			
			$replacements = array();
			$replacements[0] = $this->box["light"];
			$replacements[1] = $sensor["temp"];
			$replacements[2] = $sensor["humi"];
			$replacements[3] = $sensor["soil"];
			$replacements[4] = time();
			
			$plan["plan_condition"] =  preg_replace($keywords, $replacements, $plan["plan_condition"]);

			$eval_check = eval("if (".$plan["plan_condition"].") { return TRUE; } else { return FALSE;}");
			if ($eval_check) {
				switch ($plan["job"]) {
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
						create_watering_job();
						break;
					case 'email_notification':
						//todo
						break;
				}
				return TRUE;
			}
			else {
				return;
			}

		}
		return;
	}
}

?>