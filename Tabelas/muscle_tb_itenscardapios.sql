CREATE DATABASE  IF NOT EXISTS `muscle` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `muscle`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: muscle
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.25-MariaDB

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
-- Table structure for table `tb_itenscardapios`
--

DROP TABLE IF EXISTS `tb_itenscardapios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_itenscardapios` (
  `IdItemCardapio` int(11) NOT NULL AUTO_INCREMENT,
  `idCardapio` int(11) NOT NULL,
  `IdTipoRefeicao` int(11) NOT NULL,
  `IdAlimento` int(11) NOT NULL,
  `OrdemItem` int(11) NOT NULL,
  `Quantidade` varchar(200) NOT NULL,
  PRIMARY KEY (`IdItemCardapio`),
  KEY `idCardapio` (`idCardapio`),
  KEY `IdTipoRefeicao` (`IdTipoRefeicao`),
  KEY `IdAlimento` (`IdAlimento`),
  CONSTRAINT `tb_itenscardapios_ibfk_1` FOREIGN KEY (`idCardapio`) REFERENCES `tb_cardapios` (`idCardapio`),
  CONSTRAINT `tb_itenscardapios_ibfk_2` FOREIGN KEY (`IdTipoRefeicao`) REFERENCES `tb_tiporefeicao` (`IdTipoRefeicao`),
  CONSTRAINT `tb_itenscardapios_ibfk_3` FOREIGN KEY (`IdAlimento`) REFERENCES `tb_alimentos` (`IdAlimento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-20 14:08:49
