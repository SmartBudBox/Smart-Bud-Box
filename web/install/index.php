<?php
if ($_POST) {
	
	// Connect to MySQL server
	$conn = new mysqli($_POST["mysql_host"], $_POST["mysql_user"], $_POST["mysql_pass"], $_POST["mysql_db"], $_POST["mysql_port"]);

    if ($connconnect_error) {
        die("Verbindung zum MYSQL Server fehlgeschlagen: " . $connconnect_error);
    }
	
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
		
		$current = str_replace('MYSQL_SERVER", ""', 'MYSQL_SERVER", "'.$_POST["mysql_host"].'"', $current);
		$current = str_replace('MYSQL_DB", ""', 'MYSQL_DB", "'.$_POST["mysql_db"].'"', $current);
		$current = str_replace('MYSQL_USER", ""', 'MYSQL_USER", "'.$_POST["mysql_user"].'"', $current);
		$current = str_replace('MYSQL_PASS", ""', 'MYSQL_PASS", "'.$_POST["mysql_pass"].'"', $current);
		$current = str_replace('MYSQL_PORT", ""', 'MYSQL_PORT", "'.$_POST["mysql_port"].'"', $current);
		$current = str_replace('URL", ""', 'URL", "'.$_POST["url"].'"', $current);
		$current = str_replace('PASSWORD", ""', 'PASSWORD", "'.$_POST["password"].'"', $current);
		$current = str_replace('MAIL_ADRESS", ""', 'MAIL_ADRESS", "'.$_POST["email"].'"', $current);
		
		file_put_contents($config, $current);
		
		die('All fine, go to <a href="'.$_POST["url"].'">Login<a/>');
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
	MySQL Host<input type="text" name="mysql_host" /> <br />
	MySQL User<input type="text" name="mysql_user" /> <br />
	MySQL Password<input type="text" name="mysql_pass" /> <br />
	MySQL Database<input type="text" name="mysql_db" /> <br />
	MySQL Port<input type="text" name="mysql_port" value="3306"/> (3306 is standard)<br />
	Your E-mail<input type="text" name="email" /> <br />
	<input type="submit" />

</form>
</body>

</html>