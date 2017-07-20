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
-- Table structure for table `tb_dietas`
--

DROP TABLE IF EXISTS `tb_dietas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_dietas` (
  `IdDieta` int(11) NOT NULL AUTO_INCREMENT,
  `IdAvaliacaoFisica` int(11) NOT NULL,
  `idDietaCalorimetria` int(11) DEFAULT NULL,
  `idDietaGlicogenio` int(11) DEFAULT NULL,
  `idDietaCicloCarbo` int(11) DEFAULT NULL,
  `DataInclusao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdDieta`),
  KEY `idDietaGlicogenio` (`idDietaGlicogenio`),
  KEY `idDietaCicloCarbo` (`idDietaCicloCarbo`),
  KEY `IdAvaliacaoFisica` (`IdAvaliacaoFisica`),
  KEY `idDietaCalorimetria` (`idDietaCalorimetria`),
  CONSTRAINT `tb_dietas_ibfk_1` FOREIGN KEY (`idDietaGlicogenio`) REFERENCES `tb_dietasglicogenios` (`idDietaGlicogenio`),
  CONSTRAINT `tb_dietas_ibfk_2` FOREIGN KEY (`idDietaCicloCarbo`) REFERENCES `tb_dietascicloscarbos` (`idDietaCicloCarbo`),
  CONSTRAINT `tb_dietas_ibfk_3` FOREIGN KEY (`IdAvaliacaoFisica`) REFERENCES `tb_avaliacoesfisicas` (`IdAvaliacaoFisica`),
  CONSTRAINT `tb_dietas_ibfk_4` FOREIGN KEY (`idDietaCalorimetria`) REFERENCES `tb_dietascalorimetrias` (`idDietaCalorimetria`)
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

-- Dump completed on 2017-07-20 14:08:53
