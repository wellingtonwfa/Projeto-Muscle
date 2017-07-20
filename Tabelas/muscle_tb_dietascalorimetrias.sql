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
-- Table structure for table `tb_dietascalorimetrias`
--

DROP TABLE IF EXISTS `tb_dietascalorimetrias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_dietascalorimetrias` (
  `idDietaCalorimetria` int(11) NOT NULL AUTO_INCREMENT,
  `QtdRefeicaoCarboidrato` int(11) NOT NULL,
  `QtdRefeicaoProteina` int(11) NOT NULL,
  `QtdGramaturaCarboDia1` float DEFAULT NULL,
  `QtdGramaturaCarboDia2` float DEFAULT NULL,
  `QtdGramaturaCarboDia3` float DEFAULT NULL,
  `QtdGramaturaCarboDia4` float DEFAULT NULL,
  `QtdGramaturaCarboDia5` float DEFAULT NULL,
  `QtdGramaturaCarboDia6` float DEFAULT NULL,
  `QtdGramaturaCarboDia7` float DEFAULT NULL,
  `QtdGramaturaProteinaDia1` float DEFAULT NULL,
  `QtdGramaturaProteinaDia2` float DEFAULT NULL,
  `QtdGramaturaProteinaDia3` float DEFAULT NULL,
  `QtdGramaturaProteinaDia4` float DEFAULT NULL,
  `QtdGramaturaProteinaDia5` float DEFAULT NULL,
  `QtdGramaturaProteinaDia6` float DEFAULT NULL,
  `QtdGramaturaProteinaDia7` float DEFAULT NULL,
  `QtdConsumoCarboDia1` float DEFAULT NULL,
  `QtdConsumoCarboDia2` float DEFAULT NULL,
  `QtdConsumoCarboDia3` float DEFAULT NULL,
  `QtdConsumoCarboDia4` float DEFAULT NULL,
  `QtdConsumoCarboDia5` float DEFAULT NULL,
  `QtdConsumoCarboDia6` float DEFAULT NULL,
  `QtdConsumoCarboDia7` float DEFAULT NULL,
  `QtdConsumoProteinaDia1` float DEFAULT NULL,
  `QtdConsumoProteinaDia2` float DEFAULT NULL,
  `QtdConsumoProteinaDia3` float DEFAULT NULL,
  `QtdConsumoProteinaDia4` float DEFAULT NULL,
  `QtdConsumoProteinaDia5` float DEFAULT NULL,
  `QtdConsumoProteinaDia6` float DEFAULT NULL,
  `QtdConsumoProteinaDia7` float DEFAULT NULL,
  PRIMARY KEY (`idDietaCalorimetria`)
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

-- Dump completed on 2017-07-20 14:08:48
