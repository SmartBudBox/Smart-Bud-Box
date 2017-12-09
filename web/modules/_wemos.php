<?php

switch ($_GET["action"]) {
    case 'clear_transmissions':
        print($Wemos->clear_transmissons());
        break;
        
    case 'read_transmission_json':
        print (json_encode($Wemos->read_uc_transmisson()));
        break;
        
    case 'sensordata':
        $insert = $Wemos->create_sensor_data($_GET["temp"], $_GET["humi"], $_GET["soil"]); 
        $Wemos->compress_sensor_log();
        print($insert);
        break;
        
    case 'addon_outside_dht':
        $insert = $Wemos->insert("addons", array("name" => "outside_dht" , "box" => $_GET["box"], "parameter_1" => $_GET["temp"],"parameter_2" => $_GET["humi"])); 
        print($insert);
        break;
        
    case 'boxstatus':
        $insert = $Wemos->update_box_status($_GET["light"], $_GET["fan"], $_GET["exhaust"]);
        print($insert);
        break;
        
    case 'test':
        $Wemos->compress_sensor_log();
        break;
        
    default:
        break;
}
    
?>