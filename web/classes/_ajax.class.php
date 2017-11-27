<?php
class Ajax extends Core {
        
    function __construct() {
        parent::__construct();
    }
    
    function read_data() 
    {
        $return = array();
                
        $return["servertime"] = date('H:i:s - d.m.Y ',time());
        
        $return["fan"] = $this->box["fan"];
        $return["fan_speed"] = $this->box["status_fan"];
        $return["exhaust"] = $this->box["exhaust"];
        $return["exhaust_speed"] = $this->box["status_exhaust"];
        $return["light"] = $this->box["light"];
        
        // Sensoren & Last seen
        $this->set_order(array("time" => "DESC"));
        $this->set_limit(array("0" => "1"));
        $res = $this->get("logs_sensors", "`time` > '".$date = date('Y-m-d H:i:s', time()-60)."' AND box = '".$this->box["id"]."' ");
        if ($res) {
            $return["humi"] = $res["humi"];
            $return["soil"] = $res["soil"];
            $return["temp"] = $res["temp"];
        } else {
            $return["humi"] = "?";
            $return["soil"] = "?";
            $return["temp"] = "?";
        }
        
        $last_seen = strtotime($this->box["last_seen"]);
        $last_seen = time()-$last_seen;
        if ($last_seen > 60)
        {
            $return["offline"] = "1"; 
        }   
        else {
            $return["offline"] = "0"; 
        }
        
        
        $return["status_light"] = $this->box["status_light"];  
        $return["status_exhaust"] = $this->box["status_exhaust"]; 
        $return["status_fan"] = $this->box["status_fan"]; 


        //Fehler
        $this->set_order(array("id" => "ASC"));
        $this->set_limit(array("0" => "1"));
        $error = $this->get("messages", array("error" => "1", "box" => $this->box["id"]));
        if($error) 
        {
            $return["error"] = $error["message"];
        } 
        else {
            $return["error"] = "0";
        }

        // Infolog
        $this->set_order(array("id" => "DESC"));
        $this->set_limit(array("0" => "8"));
        $infolog = $this->get("messages", array("box" => $this->box["id"]));
        $return["info_log"] = '';

        if (isset($infolog["id"])) {
            $infoarray = array($infolog); 
        } else {
            $infoarray = $infolog;
        }
        
        if (is_array($infoarray)) {
        foreach($infoarray as $data)
        {
            $return["info_log"].='<p class="bg-'.$data["type"].'"><strong>'.$data["time"].'</strong>: '.$data["message"].'</p>';
        } 
        }


        return $return;
    }
    
    function update_data($data)
    {
        foreach ($data as $key => $value) {
            $this->update("boxes", array($key => $value), array("id" => $this->box_id));
        }
    }
  
    /**
     * set the actually growmode to vegi, flower or none and calcute from date to days on exit
     * 
     * @param string $mode mode to set: vegi, flower or none 
     * 
     * @return boolean
     */
    function set_growmode($mode) {
        // calculate the days how long this growmode was on and save to db, than set mode to none
        switch ($this->box["growmode"]) {
            case 'vegi':
                $days = strtotime($this->box["vegi_start"]);
                $days = time()-$days;
                $days = ceil($days/86400);
                $this->update("boxes", array("vegi_start" => $days, "growmode" => "none"), array("id" => $this->box["id"]));
                break;
                
            case 'flower':
                $days = strtotime($this->box["flower_start"]);
                $days = time()-$days;
                $days = ceil($days/86400);
                $this->update("boxes", array("flower_start" => $days, "growmode" => "none"), array("id" => $this->box["id"]));
                break;
            }
        
        // reload box
        $this->box = $this->get("boxes", array("id" => $this->box["id"]));
        
        // set the new mode, when there growdays calcute to date - days
        switch ($mode) {
            case 'vegi':
                $date = time()-60*60*24*$this->box["vegi_start"];
                $date = date("j.n.Y" ,$date);
                $update = $this->update("boxes", array("vegi_start" => $date, "growmode" => "vegi"), array("id" => $this->box["id"]));
                break;
            
            case 'flower':
                $date = time()-60*60*24*$this->box["flower_start"];
                $date = date("j.n.Y" ,$date);
                $update = $this->update("boxes", array("flower_start" => $date, "growmode" => "flower"), array("id" => $this->box["id"]));
                break;
                
            default:
                $update = True;
                break;
        }
        
        return $update;
    }  
    
    function disable_error() {
        $this->set_order(array("id" => "ASC"));
        $this->set_limit(array("0" => "1"));
        $error = $this->get("info_log", array("error" => "1"));

        $delete = $this->update("info_log", array("error" => "0"), array("id" => $error["id"]));

        if ($delete)
        {
            return True;
        }
        else {
            return False;
        }
    }
    
}
?>
