CREATE DATABASE  IF NOT EXISTS `infokiosk` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `infokiosk`;
-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: infokiosk
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `contentcategory`
--

DROP TABLE IF EXISTS `contentcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `contentcategory` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `IsDeleted` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contentcategory`
--

LOCK TABLES `contentcategory` WRITE;
/*!40000 ALTER TABLE `contentcategory` DISABLE KEYS */;
INSERT INTO `contentcategory` VALUES (1,'Каменный век',0),(2,'Бронзовый век',0),(3,'Железный век',0),(4,'Средневековье',0),(5,'Тест',0),(6,'Тест11',0),(7,'тест2',0),(8,'тест2',0),(9,'тест2',0),(10,'тест 3',0),(11,'gjgjgj',1),(12,'gjgjgj',1),(13,'gjgjgj',1),(14,'gjgjgj',1),(15,'gjgjgj',1),(16,'gjgjgj',1),(17,'gjgjgj',1),(18,'gjgjgj',1),(19,'gjgjgj',1),(20,'gjgjgj',1),(21,'gjgjgj',1),(22,'gjgjgj',1),(23,'dfdfdfdf',1),(24,'ewewe',1),(25,'fdfdf',1),(26,'fdfdf',1),(27,'fdfdfdfdfdf',1),(28,'dsdsd',1),(29,'wewewe',1),(30,'wewewewe',1),(31,'wewewewe',0),(32,'wewewewe',0),(33,'wewewewe',1),(34,'wewewewe',1),(35,'Тест1',1),(36,'fjfjjfjjfjfjjfjf',1),(37,'fmnfmfdjd',0);
/*!40000 ALTER TABLE `contentcategory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-30 21:16:19
