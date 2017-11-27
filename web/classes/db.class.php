<?php
class DB {
    public $conn = False;
    public $order = False;
    public $limit = False;
    public $debug = False;

    public function __construct() {
        $this -> connect();
    }

    public function connect() {
        $this -> conn = new mysqli(MYSQL_SERVER, MYSQL_USER, MYSQL_PASS, MYSQL_DB, MYSQL_PORT);

        if ($this -> conn -> connect_error) {
            die("Verbindung zum MYSQL Server fehlgeschlagen: " . $this -> conn -> connect_error);
        }
    }

    /**
     * Setzt eine ORDER BY in die Query
     *
     *
     * @param array $order array("id" => "ASC")
     *   ASC absteigend
     * DESC aufsteigend
     *
     * @return void
     */
    public function set_order($order) {
        $this -> order = $order;
    }

    /**
     * Setzt eine LIMIT in die Query
     *
     *
     * @param array $limit array("0" => "1")
     * Anfangsdatensatz , Anzahl der Datensätze
     *
     * @return void
     */
     
    public function set_limit($limit) {
        $this -> limit = $limit;
    }
    
    /**
     * Setzt eine LIMIT in die Query
     *
     *
     * @param array $limit array("0" => "1")
     * Anfangsdatensatz , Anzahl der Datensätze
     *
     * @return void
     */
     
    public function run($query) 
    {
        if ($this->debug) 
        {
           print($query); 
           print("<br />");
        }
        
        $result = $this -> conn -> query($query);
        
        return $result;
    }

    /**
     * Ruft Daten aus einer Tabelle ab
     *
     *
     * @param string $table Name der Tabelle
     * @param mixed $where Where Befehl als String oder Array array("id" => "1", "name" => "Test")
     *
     * @return boolean
     */
     function test() {
         return;
     }
    public function get($table, $where = False) {
        //$sql = "SELECT id, firstname, lastname FROM MyGuests WHERE `id` = 1";

        $sql = "SELECT * FROM " . $table . " ";

        if ($where != False) {
            $sql .= " WHERE ";
            $x = 0;
            if (is_array($where)) {
                foreach ($where as $key => $value) {
                    if ($x > 0) {
                        $sql .= " AND ";
                    }
                    $sql .= $key . " = '" . $value . "' ";
                    $x++;
                }
            } else {
                $sql .= $where;
            }

        }

        if ($this -> order != False) {
            $sql .= " ORDER BY ";

            foreach ($this->order as $key => $value) {
                $sql .= $key . " " . $value;
            }

            $this -> order = False;
        }

        if ($this -> limit != False) {
            $sql .= " LIMIT " . key($this -> limit) . "," . $this -> limit[0];
            $this -> limit = False;
        }

        $result = $this->run($sql);

        if ($result -> num_rows > 1) {
            $return = array();
            $x = 0;
            while ($row = $result -> fetch_array()) {
                $return[$x] = $row;
                $x++;
            }
            return $return;
        } elseif ($result -> num_rows > 0) {
            return $result -> fetch_array();
        } else {
            echo $this -> conn -> error;
            return False;
        }
    }

    /**
     * Fügt Daten in eine Tabelle ein
     *
     *
     * @param string $table Name der Tabelle
     * @param array $data Daten als Array: array("name" => "test", "beispiel" => "1")
     *
     * @return boolean
     */
    public function insert($table, $data) {
        $sql = "INSERT INTO " . $table . "( ";
        foreach ($data as $key => $value) {
            $sql .= $key . ",";
        }
        $sql = rtrim($sql, ",");
        $sql .= ") VALUES (";
        foreach ($data as $key => $value) {
            $sql .= "'" . $value . "',";
        }
        $sql = rtrim($sql, ",");
        $sql .= ")";

        if (!$this->run($sql) === TRUE) {
            return False;
        } else {
            return True;
        }
    }

    /**
     * Aktualisiert Daten in eienr Tabelle
     *
     *
     * @param string $table Name der Tabelle
     * @param array $data Daten als Array: array("name" => "test", "beispiel" => "1")
     * @param mixed $where Where Befehl als String oder Array array("id" => "1", "name" => "Test")
     * 
     * @return void
     */
    public function update($table, $data, $where) {
        //$sql = "UPDATE MyGuests SET lastname='Doe' WHERE id=2";
        $sql = "UPDATE " . $table . " SET ";

        foreach ($data as $key => $value) {
            $sql .= $key . "='" . $value . "' ,";
        }
        
        $sql = substr($sql, 0, -1);

        $sql .= " WHERE ";
        
        if (is_array($where)) {
            foreach ($where as $key => $value) {
                $sql .= $key . " = '" . $value . "' AND ";
            }
            $sql = substr($sql, 0, -4);
            
        } else {
            $sql .= $where;
        }

        if ($this->run($sql) === TRUE) {
            return True;
        } else {
            return False;
        }
    }

    /**
     * Löscht Daten aus eienr Tabelle
     *
     *
     * @param string $table Name der Tabelle
     * @param mixed $where Where Befehl als String oder Array array("id" => "1", "name" => "Test")
     * 
     * @return void
     */
    public function delete($table, $where) {
        //$sql = "DELETE FROM MyGuests WHERE id=3";
        $sql = "DELETE FROM " . $table . " WHERE ";

        $x = 0;
        if (is_array($where)) {
            foreach ($where as $key => $value) {
                if ($x > 0) {
                    $sql .= " AND ";
                }
                $sql .= $key . " = '" . $value . "' ";
                $x++;
            }
        } else {
            $sql .= $where;
        }

        if ($this->run($sql) === TRUE) {
            return True;
        } else {
            return False;
        }
    }

    public function query_to_array($sql) {
        $result = $this->run($sql);

        if ($result -> num_rows > 1) {
            $return = array();
            $x = 0;
            while ($row = $result -> fetch_array()) {
                $return[$x] = $row;
                $x++;
            }
            return $return;
        } elseif ($result -> num_rows > 0) {
            return $result -> fetch_array();
        } else {
            echo $this -> conn -> error;
            return False;
        }
    }
    
    public function install() {
        $sql = "
SET SQL_MODE=\"NO_AUTO_VALUE_ON_ZERO\";
SET time_zone = \"+00:00\";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;


CREATE TABLE IF NOT EXISTS `dht_plant_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `temp` float NOT NULL,
  `humi` float NOT NULL,
  `time` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `dht_room_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `temp` float NOT NULL,
  `humi` float NOT NULL,
  `time` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `fanspeed_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `value` float NOT NULL,
  `time` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `light_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `status` int(1) NOT NULL,
  `time` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `settings` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `value` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

INSERT INTO `settings` (`id`, `name`, `value`) VALUES
(1, 'light_on', '0'),
(2, 'light_off', '0'),
(3, 'light_status', '0'),
(4, 'plant_humi_min', '0'),
(5, 'plant_humi_max', '0'),
(6, 'room_temp_min', '0'),
(7, 'room_temp_max', '0'),
(8, 'room_humi_max', '0');

CREATE TABLE IF NOT EXISTS `timer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `start` int(11) NOT NULL,
  `stop` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

INSERT INTO `timer` (`id`, `name`, `start`, `stop`) VALUES
(1, 'keimung', 0, 0),
(2, 'wachstum', 0, 0),
(3, 'bluete', 0, 0),
(4, 'trocknung', 0, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
";
        if ($this->run($sql) === TRUE) {
            echo "K";
            return True;
        } else {
            echo $this -> conn -> error;
            return False;
        }
    }

    public function __destruct() {
        $this -> conn -> close();
    }

}
?>