<?php

if ($_POST || $_GET) {
	if ($_GET) {
		$mysql["host"] = $_GET["mysql_host"];
		$mysql["user"] = $_GET["mysql_user"];
		$mysql["pass"] = $_GET["mysql_pass"];
		$mysql["db"] = $_GET["mysql_db"];
		$mysql["port"] = $_GET["mysql_port"];
		$password = $_GET["password"];
		$email = $_GET["email"];
		$url = $_GET["url"];
		$language = $_GET["language"];
	}  else {
		$mysql["host"] = $_POST["mysql_host"];
		$mysql["user"] = $_POST["mysql_user"];
		$mysql["pass"] = $_POST["mysql_pass"];
		$mysql["db"] = $_POST["mysql_db"];
		$mysql["port"] = $_POST["mysql_port"];
		$password = $_POST["password"];
		$email = $_POST["email"];
		$url = $_POST["url"];
		$language = $_POST["language"];
	}
	// Connect to MySQL server
	$conn = new mysqli($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["db"], $mysql["port"]);

    if ($conn->connect_error) {
        die("Connection Error: " . $conn->connect_error);
    }
	else {
		// Temporary variable, used to store current query
		$templine = '';
		// Read in entire file
		$lines = file("database.sql");
		// Loop through each line
		foreach ($lines as $line)
		{
			// Skip it if it's a comment
			if (substr($line, 0, 2) == '--' || $line == '')
			    continue;
			
			// Add this line to the current segment
			$templine .= $line;
			// If it has a semicolon at the end, it's the end of the query
			if (substr(trim($line), -1, 1) == ';')
			{
			    // Perform the query
			    $submit = $conn->query($templine) or print('Error performing query \'<strong>' . $templine . '\': ' . mysql_error() . '<br /><br />');
			    // Reset temp variable to empty
			    $templine = '';
				if (!$submit) {
					$error = true;
				}
			}
		}
		 
		if ( !isset($error) ) {
			$config = '../config.inc.php';
			$current = file_get_contents($config);
			
			$current = str_replace('MYSQL_SERVER", ""', 'MYSQL_SERVER", "'.$mysql["host"].'"', $current);
			$current = str_replace('MYSQL_DB", ""', 'MYSQL_DB", "'.$mysql["db"].'"', $current);
			$current = str_replace('MYSQL_USER", ""', 'MYSQL_USER", "'.$mysql["user"].'"', $current);
			$current = str_replace('MYSQL_PASS", ""', 'MYSQL_PASS", "'.$mysql["pass"].'"', $current);
			$current = str_replace('MYSQL_PORT", ""', 'MYSQL_PORT", "'.$mysql["port"].'"', $current);
			$current = str_replace('URL", ""', 'URL", "'.$url.'"', $current);
			$current = str_replace('PASSWORD", ""', 'PASSWORD", "'.$password.'"', $current);
			$current = str_replace('MAIL_ADRESS", ""', 'MAIL_ADRESS", "'.$email.'"', $current);
			$current = str_replace('LANGUAGE", ""', 'LANGUAGE", "'.$language.'"', $current);
			
			file_put_contents($config, $current);
			
			die('All fine, go to <a href="'.$url.'">Login<a/>');
		}
	}
	

}
?>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title></title>
</head>

<body>

<form method="POST">
	Url <input type="text" name="url" placeholder="http://yourspace.com"/>  (without / at end)<br />
	Password<input type="text" name="password" /> <br />
	MySQL Host<input type="text" name="mysql_host" value="localhost"/> (change if u got a other host)<br />
	MySQL User<input type="text" name="mysql_user" /> <br />
	MySQL Password<input type="text" name="mysql_pass" /> <br />
	MySQL Database<input type="text" name="mysql_db" /> <br />
	MySQL Port<input type="text" name="mysql_port" value="3306"/> (3306 is standard)<br />
	Your E-mail<input type="text" name="email" /> <br />
	<input type="submit" />

</form>
</body>

</html>