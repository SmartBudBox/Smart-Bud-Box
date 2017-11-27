<?php

switch($_GET["action"]) 
{
	case 'delete_sensor_data':
		$Ajax->delete("logs_sensors", array("box" => $Ajax->box_id));
		break;
	   
    case 'read_data':
        $return = $Ajax->read_data();
        echo json_encode($return);
        break;
        
    case 'update_data' :
        $settings = json_decode($_GET["data"], true);
        $Ajax->update_data($settings);

        $Ajax->create_message_log("Settings changed");
        break;
     
    case 'insert_plan':
        $plan = json_decode($_GET["data"], true);
        $Ajax->insert("plans", array("box" => $Ajax->box_id, "job" => $plan["job"], "plan_condition" => $plan["condition"], "plan_interval" => $plan["interval"]));
        $Ajax->create_message_log("Plan created");
        break;
        
    case 'update_notes' :
        $note = $_POST["notes"];
        $Ajax->update("boxes", array("notes" => $note), array("id" => $Ajax->box_id));
        break;
        
    case 'set_growmode' :
        if ($Ajax->set_growmode($_GET["mode"])) {
            $Ajax->create_message_log("Growmode changed");
            print("1");
        } else {
            print(0);
        }
        break;
        
    case 'reset_growmode_counters' : 
        if ($Ajax->update("boxes", array("growmode" => "none", "vegi_start" => "0", "flower_start" => "0"), array("id" => $Ajax->box["id"]))) {
            $Ajax->create_message_log("Growcounter reset");
            print("1");
        } else {
            print(0);
        }
        break;
           
    case 'create_command' :
        $create = $Ajax->create_command($_GET["data"]);
        if ($create): echo "1"; else: echo "0"; endif;
        break;
        
    case 'disable_error' :
        $disable =  $Ajax->disable_error();
        if ($disable): echo "1"; else: echo "0"; endif;
        break;  
          
    case "update_exhaust":
        if ($Ajax->box["exhaust"] == "1") 
        {
            $return = $Ajax->update("boxes", array("exhaust" => "0"), array("id" => $Ajax->box["id"]));
            $Ajax->create_message_log("Exhaust set to off");
        } 
        else 
        {
            $return = $Ajax->update("boxes", array("exhaust" => "1"), array("id" => $Ajax->box["id"]));
            $Ajax->create_message_log("Exhaust set to on"); 
        }
        
        print($return);
        break;
    
    // Ventilator umschalten
    case "update_fan":
        if ($Ajax->box["fan"] == "1") 
        {
            $return = $Ajax->update("boxes", array("fan" => "0"), array("id" => $Ajax->box["id"]));
            $Ajax->create_message_log("Fan set to off");
        } 
        else 
        {
            $return = $Ajax->update("boxes", array("fan" => "1"), array("id" => $Ajax->box["id"]));
            $Ajax->create_message_log("Fan set to on"); 
        }
        
        print($return);
        break;
    
    // Licht umschalten
    case "update_light":
        if ($Ajax->box["light"] == "1") 
        {
            $return = $Ajax->update("boxes", array("light" => "0"), array("id" => $Ajax->box["id"]));
            $Ajax->create_message_log("Light set to off");
        } 
        else 
        {
            $return = $Ajax->update("boxes", array("light" => "1"), array("id" => $Ajax->box["id"]));
            $Ajax->create_message_log("Light set to on"); 
        }
        
        print($return);
        break;
        
    // Gießverogang starten
    case "watering":
		$return = $Ajax->create_watering_job();
        print($return);
        break;
        
    case "delete_transmissions":
        $Ajax->delete("_transmissions", array("recipient" => $Ajax->box_id));
        $Ajax->create_message_log("All transmissions deleted");
        break;
     
    case "delete_box":
        $Ajax->delete("_transmissions", array("recipient" => $Ajax->box_id));
        $Ajax->delete("logs_light", array("box" => $Ajax->box_id));
        $Ajax->delete("logs_sensors", array("box" => $Ajax->box_id));
        $Ajax->delete("messages", array("box" => $Ajax->box_id));
        $Ajax->delete("boxes", array("id" => $Ajax->box_id));
        break;
           
    default:
        break;
}

?>