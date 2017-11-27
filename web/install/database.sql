SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;


CREATE TABLE IF NOT EXISTS `addons` (
`id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `parameter_1` varchar(100) NOT NULL,
  `parameter_2` varchar(100) NOT NULL,
  `parameter_3` varchar(100) NOT NULL,
  `parameter_4` varchar(100) NOT NULL,
  `box` int(11) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `assistent` (
`id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `text` text NOT NULL,
  `from` int(11) NOT NULL,
  `till` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `boxes` (
`id` int(11) NOT NULL,
  `name` varchar(80) NOT NULL,
  `alias` varchar(50) NOT NULL,
  `status_light` int(1) NOT NULL DEFAULT '0',
  `status_exhaust` int(4) NOT NULL DEFAULT '0',
  `status_fan` int(4) NOT NULL DEFAULT '0',
  `exhaust_change` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `fan_change` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `notes` text NOT NULL,
  `growmode` varchar(6) NOT NULL DEFAULT 'none',
  `vegi_start` varchar(10) NOT NULL DEFAULT '0',
  `flower_start` varchar(10) NOT NULL DEFAULT '0',
  `humidity_calibration` int(3) NOT NULL DEFAULT '0',
  `temperature_calibration` int(3) NOT NULL DEFAULT '0',
  `soil_calibration` int(3) NOT NULL DEFAULT '0',
  `max_temprature` int(2) NOT NULL DEFAULT '25',
  `max_humidity` int(3) NOT NULL DEFAULT '50',
  `fan` int(1) NOT NULL DEFAULT '1',
  `exhaust` int(1) NOT NULL DEFAULT '1',
  `light` int(1) NOT NULL DEFAULT '1',
  `light_on` int(2) NOT NULL DEFAULT '18',
  `light_off` int(2) NOT NULL DEFAULT '14',
  `pump_runtime` int(5) NOT NULL DEFAULT '1000',
  `pump_repeats` int(3) NOT NULL DEFAULT '1',
  `pump_repeats_delay` int(4) NOT NULL DEFAULT '200',
  `fans_change_interval` int(4) NOT NULL DEFAULT '180',
  `fans_step` int(4) NOT NULL DEFAULT '100',
  `fans_speed_max` int(11) NOT NULL DEFAULT '1024',
  `last_seen` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `registered` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `logs_light` (
`id` int(11) NOT NULL,
  `status` int(1) NOT NULL,
  `type` varchar(10) NOT NULL,
  `box` varchar(80) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `logs_pump` (
`id` int(11) NOT NULL,
  `box` varchar(80) NOT NULL,
  `soil` float NOT NULL,
  `type` varchar(10) NOT NULL,
  `runtime` int(11) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `logs_sensors` (
`id` int(11) NOT NULL,
  `temp` float NOT NULL,
  `humi` float NOT NULL,
  `soil` float NOT NULL,
  `box` varchar(80) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `messages` (
`id` int(11) NOT NULL,
  `box` varchar(80) NOT NULL,
  `message` varchar(255) NOT NULL,
  `type` varchar(20) NOT NULL,
  `error` int(1) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `plans` (
`id` int(11) NOT NULL,
  `box` int(11) NOT NULL,
  `job` varchar(30) NOT NULL,
  `plan_condition` varchar(250) NOT NULL,
  `plan_interval` int(11) NOT NULL,
  `last_execution` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `_transmissions` (
`id` int(11) NOT NULL,
  `sender` varchar(80) NOT NULL,
  `recipient` varchar(80) NOT NULL,
  `data` text NOT NULL,
  `validity_from` datetime NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


ALTER TABLE `addons`
 ADD PRIMARY KEY (`id`);

ALTER TABLE `assistent`
 ADD PRIMARY KEY (`id`);

ALTER TABLE `boxes`
 ADD PRIMARY KEY (`id`), ADD UNIQUE KEY `name` (`name`);

ALTER TABLE `logs_light`
 ADD PRIMARY KEY (`id`);

ALTER TABLE `logs_pump`
 ADD PRIMARY KEY (`id`);

ALTER TABLE `logs_sensors`
 ADD PRIMARY KEY (`id`);

ALTER TABLE `messages`
 ADD PRIMARY KEY (`id`);

ALTER TABLE `plans`
 ADD PRIMARY KEY (`id`), ADD KEY `id` (`id`);

ALTER TABLE `_transmissions`
 ADD PRIMARY KEY (`id`);


ALTER TABLE `addons`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
ALTER TABLE `assistent`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
ALTER TABLE `boxes`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
ALTER TABLE `logs_light`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
ALTER TABLE `logs_pump`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
ALTER TABLE `logs_sensors`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
ALTER TABLE `messages`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
ALTER TABLE `plans`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
ALTER TABLE `_transmissions`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;