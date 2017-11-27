<?php
require_once 'config.inc.php';
require_once 'classes/db.class.php';

$db = new DB(MYSQL_SERVER, MYSQL_USER, MYSQL_PASS, MYSQL_DB);

$redirect = 'Location: '.URL.'/index.php';

if ( isset($_COOKIE["password"]) && $_COOKIE["password"] == PASSWORD ) 
{
    header($redirect);
}

if ( isset($_SESSION["password"]) && $_SESSION["password"] == PASSWORD ) 
{
    header($redirect);
}

if ( $_POST )
{
    if ( $_POST["password"] == PASSWORD ) {
        if ( $_POST["save_pw"] == "1") {
           setcookie("password",$_POST["password"] , time() + (86400 * 30), "/");
        }
        else {
            $_SESSION["password"] = $_POST["password"]; 
        }
    }
    
    header($redirect);
}
?>

<!DOCTYPE html>
<html lang="de">
    <html>
        <body>
            <form method="POST">
                <input name="password" type="password" />
                <select name="save_pw"><option value="0">Nicht Speichern</option><option value="1">Speichern</option></select>
                <input type="submit" value="go" />
                
            </form>
        </body>
    </html>