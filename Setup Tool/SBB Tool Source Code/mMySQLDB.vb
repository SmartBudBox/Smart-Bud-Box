Module mMySQLDB

    Public Sub ErstelleMySQL_DB_V1()
        Dim SQL As New cMySQL

        SQL._MySQL_Server = My.Settings.mySQLServer
        SQL._mySQL_DataBase = My.Settings.mySQLDatabase
        SQL._MySQL_User = My.Settings.mySQLUser
        SQL._mySQL_Password = My.Settings.mySQLPassword
        SQL._mySQL_PORT = My.Settings.myySQLPort

        SQL.SetConnectionData()

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Download\WebServer\install\database.sql")
        SQL.SQLBefehl(fileReader)
        'MsgBox(fileReader)

        'frmInstall.AM("Erstelle Tabelle Addons")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `addons` (`id` int(11) NOT NULL,`name` varchar(100) NOT NULL, `parameter_1` varchar(100) NOT NULL,  `parameter_2` varchar(100) NOT NULL,  `parameter_3` varchar(100) NOT NULL,  `parameter_4` varchar(100) NOT NULL,  `box` int(11) NOT NULL,  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Erstelle Tabelle `assistent`")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `assistent` (`id` int(11) NOT NULL,  `name` varchar(100) NOT NULL,  `text` text NOT NULL,  `from` int(11) NOT NULL,  `till` int(11) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Erstelle Tabelle ``boxes``")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `boxes` (`id` int(11) NOT NULL,  `name` varchar(80) NOT NULL,  `alias` varchar(50) NOT NULL,  `status_light` int(1) NOT NULL DEFAULT '0',  `status_exhaust` int(4) NOT NULL DEFAULT '0',  `status_fan` int(4) NOT NULL DEFAULT '0',  `exhaust_change` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,  `fan_change` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,  `notes` text NOT NULL,  `growmode` varchar(6) NOT NULL DEFAULT 'none',  `vegi_start` varchar(10) NOT NULL DEFAULT '0',  `flower_start` varchar(10) NOT NULL DEFAULT '0',  `humidity_calibration` int(3) NOT NULL DEFAULT '0',  `temperature_calibration` int(3) NOT NULL DEFAULT '0',  `soil_calibration` int(3) NOT NULL DEFAULT '0',  `max_temprature` int(2) NOT NULL DEFAULT '25',  `max_humidity` int(3) NOT NULL DEFAULT '50',  `watering_auto` int(1) NOT NULL DEFAULT '0',  `fan` int(1) NOT NULL DEFAULT '1',  `exhaust` int(1) NOT NULL DEFAULT '1',  `light` int(1) NOT NULL DEFAULT '1',  `light_on` int(2) NOT NULL DEFAULT '18',  `light_off` int(2) NOT NULL DEFAULT '14',  `pump_runtime` int(5) NOT NULL DEFAULT '1000',  `pump_repeats` int(3) NOT NULL DEFAULT '1',  `pump_repeats_delay` int(4) NOT NULL DEFAULT '200',  `watering_min_soil` int(3) NOT NULL DEFAULT '360',  `watering_trys` int(2) NOT NULL DEFAULT '2',  `fans_change_interval` int(4) NOT NULL DEFAULT '180',  `fans_step` int(4) NOT NULL DEFAULT '100',  `fans_speed_max` int(11) NOT NULL DEFAULT '1024',  `last_seen` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,  `registered` datetime NOT NULL) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Erstelle Tabelle `logs_light`")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `logs_light` (`id` int(11) NOT NULL,  `status` int(1) NOT NULL,  `type` varchar(10) NOT NULL,  `box` varchar(80) NOT NULL,  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP) ENGINE=MyISAM AUTO_INCREMENT=554 DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Erstelle Tabelle `logs_pump`")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `logs_pump` (`id` int(11) NOT NULL,  `box` varchar(80) NOT NULL,  `soil` float NOT NULL,  `type` varchar(10) NOT NULL,  `runtime` int(11) NOT NULL,  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP) ENGINE=InnoDB AUTO_INCREMENT=315 DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Erstelle Tabelle `logs_sensors`")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `logs_sensors` (`id` int(11) NOT NULL,  `temp` float NOT NULL,  `humi` float NOT NULL,  `soil` float NOT NULL,  `box` varchar(80) NOT NULL,  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP) ENGINE=InnoDB AUTO_INCREMENT=1460340 DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Erstelle Tabelle `messages`")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `messages` (`id` int(11) NOT NULL,  `box` varchar(80) NOT NULL,  `message` varchar(255) NOT NULL,  `type` varchar(20) NOT NULL,  `error` int(1) NOT NULL,  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP) ENGINE=InnoDB AUTO_INCREMENT=17662 DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Erstelle Tabelle `plans")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `plans` (`id` int(11) NOT NULL,  `box` int(11) NOT NULL,  `job` varchar(30) NOT NULL,  `plan_condition` varchar(30) NOT NULL,  `value` varchar(30) NOT NULL,  `plan_interval` int(11) NOT NULL,  `last_execution` datetime NOT NULL) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Erstelle Tabelle '_transmissions'")
        'SQL.SQLBefehl("CREATE TABLE IF NOT EXISTS `_transmissions` (`id` int(11) NOT NULL,  `sender` varchar(80) NOT NULL,  `recipient` varchar(80) NOT NULL,  `data` text NOT NULL,  `validity_from` datetime NOT NULL,  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP) ENGINE=InnoDB AUTO_INCREMENT=17026 DEFAULT CHARSET=latin1;")

        'frmInstall.AM("Setze Indizes")
        'SQL.SQLBefehl("ALTER TABLE `addons` " _
        '            & "ADD PRIMARY KEY (`id`); " _
        '            & "ALTER TABLE `assistent` " _
        '            & "ADD PRIMARY KEY (`id`);")

    End Sub

End Module
