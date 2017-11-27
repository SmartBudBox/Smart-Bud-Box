<?php

class Main extends Core {
    public $flot = array();
    public $grow_day = FALSE;
    public $boxes = FALSE;

    
    function __construct() 
    {
        parent::__construct();
        $this->get_boxes(); // get all boxes
        $this->get_flots(24*5); // generate data for flot.js (days_in_hours)
    }

    /**
     * Get Sensor data for Flot and compress data
     * 
     * @param int $timerange Range in Hours
     * 
     * @return void
     */
    function get_flots($timerange) {
        $data = array();
        
        $this->flot["humi"] = array();
        $this->flot["temp"] = array();
        $this->flot["soil"] = array();
        $this->flot["time"] = array();
        
        $full_hour = date("i") * 60 + date("s");
        $from = time() - $full_hour;
        $from = $from - 60*60; // 21:00:00
        $to = $from + 3599; // begin from last hour, not current // 21:59:59

        for ($x=0; $x<$timerange; $x++) {
            $y = $this->mysql_datetime($from);
            $z = $this->mysql_datetime($to);
            
            $log = $this->query_to_array("SELECT * FROM logs_sensors WHERE time BETWEEN '". $y."' AND '".$z."' AND box = '".$this->box["id"]."'");
            
            // if no data put 0 on it and count further
            if (!$log) {
                array_push($this->flot["humi"], "0");
                array_push($this->flot["temp"], "0");
                array_push($this->flot["soil"], "0");
                array_push($this->flot["time"], $from); 
                
                $to = $to - 60*60;
                $from = $from - 60*60;
                continue; 
            }
   
            // if more than one result compress them into one and save it, delete the others
            if ($log && !isset($log["id"])) {
                
                $average = array();
                $average["humi"] = "";
                $average["temp"] = "";
                $average["soil"] = "";
                
                foreach ($log as $value) {
                    $average["humi"]+= $value["humi"];
                    $average["temp"]+= $value["temp"];
                    $average["soil"]+= $value["soil"];
                    $average["time"] = $value["time"];
                    
                    $this->delete("logs_sensors", array("id" => $value["id"]));
                }
                
                $count = count($log);
                unset($log);
                
                $log = array();
                $log["humi"] = $average["humi"]/$count;
                $log["temp"] = $average["temp"]/$count;
                $log["soil"] = $average["soil"]/$count;
                
                $this->insert("logs_sensors", array("humi" => $log["humi"], "temp" => $log["temp"], "soil" => $log["soil"], "time" => $y , "box" => $this->box["id"] ));
            }
            
            // make soil smaller for flot
            $log["soil"] = $log["soil"] / 10;
            
            
           
            array_push($this->flot["humi"], $log["humi"]);
            array_push($this->flot["temp"], $log["temp"]);
            array_push($this->flot["soil"], $log["soil"]);
            array_push($this->flot["time"], $from);
            
            $to = $to - 60*60;
            $from = $from - 60*60;

        } 
        $this->flot["humi"] = array_reverse($this->flot["humi"]);
        $this->flot["temp"] = array_reverse($this->flot["temp"]);
        $this->flot["soil"] = array_reverse($this->flot["soil"]);
        
        return;
    }
   
    function get_boxes() {
        $get = $this->get("boxes"); 
        
        if (isset($get["id"])) 
        {
            $this->boxes = array($get);
        } 
        else 
        {
            $this->boxes = $get;
        }
        
        return;
    } 

    function get_last_mold() {
        $this->set_order(array("id" => "DESC"));
        $this->set_limit(array("0" => "1"));
        $get = $this->get("logs_pump", array("box" => $this->box["id"])); 
        
        if (!$get) {
            return;
        }
        
        $time = strtotime($get["time"]);
        $time = time()-$time;
        $time = $time / 60 / 60 / 24;
        $time = "zuletzt ".round($time, 2)." Tage";
        
        return $time;
    }

    /**
     * get the growdays since start for vegi or flower and print it for interface
     * 
     * @param string $mode growmode vegi or flower
     * 
     * @return void
     */
    function show_growday($mode) {
        switch ($mode) {
            case 'vegi':
                $mode = "vegi_start";
                break;
            case 'flower':
                $mode = "flower_start";
                break;
        }
        
        
        if (strtotime($this->box[$mode])) {
            $days = time()-strtotime($this->box[$mode]);
            $days = ceil($days/86400);
            
            print($days);
        } 
        else {
            print($this->box[$mode]);
        }
    }
}
?>