-- MySQL dump 10.13  Distrib 5.7.19, for Linux (x86_64)
--
-- Host: 127.0.0.1    Database: WallDB
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
-- Table structure for table `Comments`
--

DROP TABLE IF EXISTS `Comments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Comments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `comment` text COLLATE utf8mb4_unicode_ci,
  `quote_id` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Comments`
--

LOCK TABLES `Comments` WRITE;
/*!40000 ALTER TABLE `Comments` DISABLE KEYS */;
INSERT INTO `Comments` VALUES (1,'now',7,1,'2017-11-26 02:56:34','2017-11-26 02:56:34'),(2,'catch them',6,1,'2017-11-26 03:23:50','2017-11-26 03:23:50'),(3,'this works',7,1,'2017-11-26 03:24:54','2017-11-26 03:24:54'),(4,'I would not',5,1,'2017-11-26 03:30:54','2017-11-26 03:30:54'),(5,'My turn',7,2,'2017-11-26 03:35:56','2017-11-26 03:35:56');
/*!40000 ALTER TABLE `Comments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Quotes`
--

DROP TABLE IF EXISTS `Quotes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Quotes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `quote` text COLLATE utf8mb4_unicode_ci,
  `user_id` int(11) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Quotes`
--

LOCK TABLES `Quotes` WRITE;
/*!40000 ALTER TABLE `Quotes` DISABLE KEYS */;
INSERT INTO `Quotes` VALUES (3,'julie is prego',1,'2017-11-26 00:22:21','2017-11-26 00:22:21'),(4,'how does thy fly',1,'2017-11-26 00:26:31','2017-11-26 00:26:31'),(5,'i condemned my only friend',1,'2017-11-26 00:27:10','2017-11-26 00:27:10'),(6,'do you want to get me some juice',1,'2017-11-26 00:54:48','2017-11-26 00:54:48'),(7,'becuase I love you',1,'2017-11-26 00:56:47','2017-11-26 00:56:47');
/*!40000 ALTER TABLE `Quotes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

LOCK TABLES `Users` WRITE;
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
INSERT INTO `Users` VALUES (1,'Eric Drake Jones','password','ericdrakejones@gmail.com',NULL,NULL),(2,'Juleika Jones','password','julieperez76@yahoo.com','2017-11-26 03:35:41','2017-11-26 03:35:41');
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

-- Dump completed on 2017-11-26  3:38:05
