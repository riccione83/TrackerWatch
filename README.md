= TrackerWatch
This is a server for watch that send SOS/Command via GPRS or SMS. It need for work a GSM Modem (I've used a Telit GM862-Quad).
In the option file you should set all the information of the software:

COM_PORT = COM7
Here you should set the COM port of your modem

TCP_PORT = 8001
Here the port where GPRS devices should connect

SQL_SERVER_IP = 192.168.2.83
DATABASE = watch
DB_USER = dbuser
DB_PASSWORD = dbuser
Here you set the information for the DB (Please read below how to create the MySQL DB)

IS_SERVER = true
This is used to set if the application should start as Server or Client.

SERVER_IP = 192.168.2.252
SERVER_PORT = 8002
This is used to intercomunicate between Client and Server.

Please check that you have this port opened in your firewall.


To create the MySQL Database, please use this (Copy and paste in your database management gui),


-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host:        Database: watch
-- ------------------------------------------------------
-- Server version	5.7.11-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `alarm`
--

DROP TABLE IF EXISTS `alarm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alarm` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DeviceID` varchar(10) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `ArrivalTimeDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `ManagedByID` varchar(10) DEFAULT NULL,
  `Note` longtext,
  `Closed` tinyint(4) DEFAULT '0',
  `LastModifiedTime` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `Latitude` varchar(10) DEFAULT NULL,
  `Longitude` varchar(10) DEFAULT NULL,
  `Event` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `commands`
--

DROP TABLE IF EXISTS `commands`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `commands` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `command` varchar(45) DEFAULT NULL,
  `deviceID` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `devices`
--

DROP TABLE IF EXISTS `devices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devices` (
  `ID` varchar(10) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `TelephoneNumber` varchar(20) DEFAULT NULL,
  `IMEI` varchar(45) DEFAULT NULL,
  `Note` varchar(45) DEFAULT NULL,
  `Version` varchar(45) DEFAULT NULL,
  `IP` varchar(45) DEFAULT NULL,
  `Port` varchar(45) DEFAULT NULL,
  `CenterNumber` varchar(45) DEFAULT NULL,
  `SlaveNumber` varchar(45) DEFAULT NULL,
  `SOS1` varchar(45) DEFAULT NULL,
  `SOS2` varchar(45) DEFAULT NULL,
  `SOS3` varchar(45) DEFAULT NULL,
  `UploadTime` varchar(45) DEFAULT NULL,
  `BatteryLevel` varchar(45) DEFAULT NULL,
  `Language` varchar(45) DEFAULT NULL,
  `TimeZone` varchar(45) DEFAULT NULL,
  `GPS` varchar(45) DEFAULT NULL,
  `GPRS` varchar(45) DEFAULT NULL,
  `LastComunicationTime` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `LastPositionLatitude` varchar(45) DEFAULT NULL,
  `LastPositionLongitude` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `mobile_user`
--

DROP TABLE IF EXISTS `mobile_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mobile_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` varchar(45) DEFAULT NULL,
  `user_pass` varchar(45) DEFAULT NULL,
  `device_uid` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `References` longtext,
  `Note` longtext,
  `Address` varchar(45) NOT NULL,
  `City` varchar(45) NOT NULL,
  `Province` varchar(2) NOT NULL,
  `CAP` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
