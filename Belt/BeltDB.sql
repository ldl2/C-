-- MySQL dump 10.13  Distrib 5.7.19, for Linux (x86_64)
--
-- Host: 127.0.0.1    Database: BeltDB
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.28-MariaDB

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
-- Table structure for table `Auctions`
--

DROP TABLE IF EXISTS `Auctions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Auctions` (
  `Auctionid` int(11) NOT NULL AUTO_INCREMENT,
  `product` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `startingbid` double DEFAULT NULL,
  `enddate` datetime DEFAULT NULL,
  `description` text COLLATE utf8mb4_unicode_ci,
  `Userid` int(11) DEFAULT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Auctionid`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Auctions`
--

LOCK TABLES `Auctions` WRITE;
/*!40000 ALTER TABLE `Auctions` DISABLE KEYS */;
INSERT INTO `Auctions` VALUES (5,'Mia',600,'2017-12-25 00:00:00','Loner cat for his personal snuggling',1,'2017-12-03 17:31:40','2017-12-03 17:31:40'),(6,'Lani',600,'2017-12-10 00:00:00','She doesn\'t like cats but likes people',2,'2017-12-03 18:19:34','2017-12-03 18:19:34');
/*!40000 ALTER TABLE `Auctions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Bids`
--

DROP TABLE IF EXISTS `Bids`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Bids` (
  `Bidid` int(11) NOT NULL AUTO_INCREMENT,
  `amount` double DEFAULT NULL,
  `Auctionid` int(11) DEFAULT NULL,
  `Userid` int(11) DEFAULT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Bidid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Bids`
--

LOCK TABLES `Bids` WRITE;
/*!40000 ALTER TABLE `Bids` DISABLE KEYS */;
INSERT INTO `Bids` VALUES (1,600,1,2,'2017-12-03 03:43:58','2017-12-03 03:43:58'),(2,700,1,2,'2017-12-03 04:01:50','2017-12-03 04:01:50'),(3,701,1,2,'2017-12-03 05:26:49','2017-12-03 05:26:49'),(4,600,6,2,'2017-12-03 18:27:14','2017-12-03 18:27:14'),(5,600,5,2,'2017-12-03 18:27:32','2017-12-03 18:27:32');
/*!40000 ALTER TABLE `Bids` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Users` (
  `Userid` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `lastname` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `username` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `wallet` double DEFAULT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Userid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

LOCK TABLES `Users` WRITE;
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
INSERT INTO `Users` VALUES (1,'Eric','Jones','ldl2','AQAAAAEAACcQAAAAEHV1bKa0O/zIwHjDom+1Iz5WCz+uzoHBApEmVILakM9FYuifJeRcId6KNDtDryYdpQ==',1000,'2017-12-02 23:10:20','2017-12-02 23:10:20'),(2,'Juleika','Jones','jperez','AQAAAAEAACcQAAAAEBoLABbpyIgm23goYYAKBLjzrqJ3EJnvi24jm7qgTSz1q2AmvtNTNsH615PGHBvAhg==',1000,'2017-12-03 01:12:33','2017-12-03 01:12:33'),(3,'Phil','Colston','sheild','AQAAAAEAACcQAAAAEJWAZVl1v6ZSDW+nRzxL9krVsj0fm8PajFz/8zZWy+/jmE63Kz4xVZUA1VKnyFffKA==',1000,'2017-12-03 01:30:07','2017-12-03 01:30:07'),(4,'Keira','Jones','baby','AQAAAAEAACcQAAAAEKlxVCmJS3wl5olv6fpsersgkrgPt52PPdh84ZdEqo5ImYqcG8Ens83W8AhK+k+WaQ==',1000,'2017-12-03 01:35:44','2017-12-03 01:35:44'),(5,'NIck','Fury','Fury','AQAAAAEAACcQAAAAEInxU9hAbpXl1hMUDuGdK2gPDUQXjPlcIeQ3ssM08WtcF56272+E+wA6GABoAiId5A==',1000,'2017-12-03 01:39:54','2017-12-03 01:39:54');
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-03 18:37:24
