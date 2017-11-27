<?php
session_start();

require_once 'config.inc.php';
require_once 'classes/db.class.php';
require_once 'classes/core.class.php';

$Core = new Core;


$redirect = 'Location: '.URL.'/index.php?page=login';
if (!isset($_GET["page"])) { $_GET["page"] = "main"; }

if ( (!isset($_COOKIE["password"]) || $_COOKIE["password"] != PASSWORD)  &&  ($_GET["page"] != "login")) 
{
    if ( !isset($_SESSION["password"]) || $_SESSION["password"] != PASSWORD ) 
    {
        if ( !isset($_GET["password"]) || $_GET["password"] != PASSWORD) 
        {
            header($redirect);
            die();   
        }
    }
}



switch ($_GET["page"]) 
{
    case 'wemos':
        if (!isset($_GET["box"])) { die(); }
        require_once 'classes/_wemos.class.php';
        $Wemos = new Wemos($_GET["box"]);
        include("modules/_wemos.php");
        break;
        
    case 'ajax':
        require_once 'classes/_ajax.class.php';
        $Ajax = new Ajax;
        include("modules/_ajax.php");
        break;
        
    case 'login':
        require_once 'classes/main.class.php';
        $Main = new Main;
        include("modules/login.php");
        break;
        
	case 'main':
		require_once 'classes/main.class.php';
        $Main = new Main;
        include("modules/main.php");
        break;
        
    default:
        die("404");
        break;
}



?>