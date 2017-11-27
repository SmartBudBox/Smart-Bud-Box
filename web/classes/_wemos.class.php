<?php

class Wemos extends Core 
{
    public $box_name = FALSE;
    public $settings = FALSE;
    
    function __construct($box_name) 
    {
        parent::__construct();
        $this->box_login($box_name);
        
    }
    
    function set_box_name($name) {
        $this->box_name = $name;
        return;
    }
    
      
     /**
     * calcutes what is to do and put the commands directly to transmissons
     *
     * @return void
     */
	function main() 
    {
        // if last seen bigger than timeout dont get it
        $timeout = date('Y-m-d H:i:s', time()-61);
        $h =  date('G'); 
        if ($this->box["light_on"] > $this->box["light_off"] && $this->box["light"] == "1") {
            if ($h >= $this->box["light_on"]) {
                if ($h < $this->box["light_on"] && $h > $this->box["light_off"]) {
                    $light = "0";
                }
                else {
                    $light = "1";
                }
            } 
            else {
                if ($h < $this->box["light_off"]) {
                    $light = "1";
                }
                else {
                    $light = "0";
                }
            }   
        } 
        elseif ($this->box["light_on"] < $this->box["light_off"] && $this->box["light"] == "1") {
            if ($h >= $this->box["light_on"]) {
                if ($h < $this->box["light_off"]) {
                   $light = "1"; 
                }
                else {
                    $light = "0";
                }
            } 
            else {
                $light = "0";
            }
        }
		elseif ($this->box["light"] == "0") {
                $light = "0";
        }
        
        if (isset($light) && $light != $this->box["status_light"]) {
                $data = array();
                $data["command"] = "switch_light";
                $data["value"] = $light;

                $this->create_transmisson("host", $this->box["id"], $data);
                
                unset($light);
        }
        
		$fans_min = "40";
		$fans_max = $this->box["fans_speed_max"];

            
		// exhaust
            
            // check if the interval for next change is arrived
            $change_check = time() - strtotime($this->box["exhaust_change"]);
            if ($change_check > $this->box["fans_change_interval"]) {
                $change_check = TRUE;
            } else {
                $change_check = FALSE;
            }
            
            
            if ($this->box["exhaust"] == "1"  && $change_check)
            {
                $this->set_limit(array("0" => "1"));
                $this->set_order(array("id" => "DESC"));
                $log = $this->get("logs_sensors", "`time` > '".$timeout."' AND `box` = '".$this->box["id"]."'");
                
                if (is_array($log)) {
                    // room humi or temp to high, more speed, 1023 is max
                    if (round($log["humi"]) > $this->box["max_humidity"] &&  $this->box["status_exhaust"] < $fans_max) 
                    {
                        $exhaust = $this->box["status_exhaust"] + $this->box["fans_step"];
                        
                        if ($exhaust > $fans_max)
                        {
                            $exhaust = $fans_max;
                        } 
                    }
                    // if all fine turn it down, 40 is min

                    elseif(round($log["humi"]) < $this->box["max_humidity"] && $this->box["status_exhaust"] > $fans_min) 
                    {

                        $exhaust = $this->box["status_exhaust"] - $this->box["fans_step"];
                                
                        if ($exhaust < $fans_min)
                        {
                            $exhaust = $fans_min;
    
                        }
                    }
                }

                if (isset($exhaust))
                {
                    $data = array();
                    $data["command"] = "set_exhaust";
                    $data["value"] = $exhaust;
                    
                    $this->create_transmisson("host", $this->box["id"], $data);
                    
                    // update cahnge datetime in boxes
                    $this->update("boxes", array("exhaust_change" => $this->mysql_datetime()), array("id" => $this->box["id"]));
                    
                    unset($exhaust);
                    unset($log);
                }
            }
            elseif ($this->box["status_exhaust"] > $fans_min && $change_check)
            {
                $data = array();
                $data["command"] = "set_exhaust";
                $data["value"] = $fans_min;
                    
                $this->create_transmisson("host", $this->box["id"], $data);
            }
            
            // fan
            
            // check if the interval fr next change is arrived
            $change_check = time() - strtotime($this->box["fan_change"]);
            if ($change_check > $this->box["fans_change_interval"]) {
                $change_check = TRUE;
            } else {
                $change_check = FALSE;
            }
            
            if ($this->box["fan"] == "1" && $change_check)
            {
                // get lateest log to check if all fine
                $this->set_limit(array("0" => "1"));
                $this->set_order(array("id" => "DESC"));
                $log = $this->get("logs_sensors", "`time` > '".$timeout."' AND `box` = '".$this->box["id"]."'");
                
                if (is_array($log)) {
                    // room temp to high, more speed, 1023 is max
                    if ( round ($log["temp"]) > $this->box["max_temprature"] && $this->box["status_fan"] < $fans_max) 
                    {
                        $fan = $this->box["status_fan"] + $this->box["fans_step"];
                        
                        if ($fan > $fans_max)
                        {
                            $fan = $fans_max;
                        } 
                    }
                    // if all fine turn it down, 40 is min
                    elseif (round($log["temp"]) < $this->box["max_temprature"] && $this->box["status_fan"] > $fans_min)
                    {
                        $fan = $this->box["status_fan"] - $this->box["fans_step"];
                            
                        if ($fan < $fans_min)
                        {
                            $fan = $fans_min;
                        }  
                    }
                }

                if (isset($fan))
                {
                    $data = array();
                    $data["command"] = "set_fan";
                    $data["value"] = $fan;
                    
                    $this->create_transmisson("host", $this->box["id"], $data);
                    
                    // update change datetime in boxes
                    $this->update("boxes", array("fan_change" => $this->mysql_datetime()), array("id" => $this->box["id"]));
                    
                    unset($fan);
                    unset($log);
                }
            }
            elseif ($this->box["status_fan"] > $fans_min && $change_check)
            {
                $data = array();
                $data["command"] = "set_fan";
                $data["value"] = $fans_min;
                    
                $this->create_transmisson("host", $this->box["id"], $data);
            }
            
        return;
    }
    

    
 	/**
     * read a new transmisson wich is validity from now, delete it and return
     *
     * @return boolean
     */
    function read_transmisson() {
       // first do the main function
       $this->main();
        
        // get the last validity transmission
        $datetime = $this->mysql_datetime();
        
        $this->set_order(array("id" => "ASC"));
        $this->set_limit(array("0" => "1"));
        $transmisson = $this->get("_transmissions", "`recipient` = '".$this->box["id"]."' AND `validity_from` < '".$datetime."'");
           
        if ($transmisson)
        {
            $command = json_decode($transmisson["data"], true);
            
            // if light on/off or watering than write into log table
            switch ($command["command"]) {
                case "switch_light": 
                    $this->insert("logs_light", array("status" => $command["value"], "type" => "normal" , "box" => $this->box["id"]));    
                    break;
    
                case "watering": 
                    $this->insert("logs_pump", array("soil" => "1", "type" => "normal", "runtime" => $command["value"] , "box" => $this->box["id"])); 
                    break;
            }
               
           // delete from db and output    
           $this->delete("_transmissions", array("id" => $transmisson["id"]));
           $transmisson["data"] = json_decode($transmisson["data"]);

           $return = array();
           $return["command"] = $transmisson["data"]->command;
           $return["value"] = $transmisson["data"]->value;
           
           return $return;
       }
       else 
       {
          return FALSE;
       } 
    }
    
    /**
     * update the last_seen on boxes or create a new box on first time
     *
     * @return boolean
     */
    function box_login($box_name) {
        $this->set_box_name($box_name);
        
        $box = $this->get("boxes", array("name" => $this->box_name));        
        
        // register box on first time
        if (!$box) {
           $this->insert("boxes", array("name" => $this->box_name, "registered" => date('Y-m-d H:i:s'))); 
           
           $box = $this->get("boxes", array("name" => $this->box_name));
        }
        
        $this->box = $box;
        

        $datetime = date('Y-m-d H:i:s');
        $update = $this->update("boxes", array("last_seen" => $datetime), array("id" => $this->box["id"]));
        
        return $update;
    }

    /**
     * create a new log with sensor datas
     *
     * @return boolean
     */
    function create_sensor_data($temp, $humi, $soil) {
        $temp = $temp + $this->box["temperature_calibration"];
        $humi = $humi + $this->box["humidity_calibration"];
        $soil = $soil + $this->box["soil_calibration"];
        $data  = array(
            "temp"  => $temp,
            "humi"  => $humi,
            "soil"  => $soil,
            "box"   => $this->box["id"]
        );
        
        $insert = $this->insert("logs_sensors", $data);
        
        $this->compress_sensor_data();
        
        return $insert;
    }
    
    function compress_sensor_data() {
        return;
    }
    
    /**
     * update the current status of light, fan and exhaust
     *
     * @return boolean
     */
    function update_box_status($light, $fan, $exhaust) {
        $data  = array(
            "status_light"  => $light,
            "status_fan"  => $fan,
            "status_exhaust"  => $exhaust
        );

        $update = $this->update("boxes", $data, array("id" => $this->box["id"]));
        
        return $update;
    }
    
    /**
     * undocumented function
     *
     * @return void
     * @author  
     */
    function clear_transmissons() {
        $delete = $this->delete("_transmissions", array("recipient" => $this->box_name));
        
        $this->update("boxes", array("status_fan" => "1024", "status_exhaust" => "1024"), array("id" => $this->box["id"]));
        
        return $delete;
    }
    
    function compress_sensor_log() {
        $time_current = $this->mysql_datetime();
        $minutes = date("i");
        $secounds = date("s"); 
        
        $x = $minutes * 60 + $secounds; 
        $x = time()-$x-1;
        // x is now the last timestamp from the last our, now is 18:37 and timestamp is 17:59
        // SELECT * FROM logs_sensors WHERE time BETWEEN '2017-07-09 18:00:00' AND '2017-07-09 18:32:46'
        
        // logs abrufen von x
        // wenn mehr asl ein ergeniss, durschnitt rechnen
        // alle löschen und durschnitt rein
        // wenn nicht mehr als ein ergebniss dann break 
        // zeit minus 60*60 und weiter
        $to = $this->mysql_datetime($x);
        $from = $x - 60*60+1;
        $from = $this->mysql_datetime($from);
        $logs = $this->query_to_array("SELECT * FROM logs_sensors WHERE time BETWEEN '". $from."' AND '".$to."' AND box = '".$this->box["id"]."'");
        
        if ($logs && !isset($logs["id"])) {
            $new_log = array();
            $new_log["temp"] = "";
            $new_log["humi"] = "";
            $new_log["soil"] = "";
            
            foreach ($logs as $log) {
                $new_log["temp"]+= $log["temp"];
                $new_log["humi"]+= $log["humi"];
                $new_log["soil"]+= $log["soil"];
            }
            
            $array_length = count($logs);
            $new_log["temp"]    = round($new_log["temp"] / $array_length, 2);
            $new_log["humi"]    = round($new_log["humi"] / $array_length, 2);
            $new_log["soil"]    = round($new_log["soil"] / $array_length, 2);
            $new_log["box"]     = $this->box["id"];
            $new_log["time"]    = $from;
            
            $this->run("DELETE FROM logs_sensors WHERE time BETWEEN '". $from."' AND '".$to."' AND box = '".$this->box["id"]."'");
            $this->insert("logs_sensors", $new_log);
            
        } else {
            return;
        }
        return;
    }
    

    
}
?>