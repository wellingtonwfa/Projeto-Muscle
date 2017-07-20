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
-- Table structure for table `tb_dietasglicogenios`
--

DROP TABLE IF EXISTS `tb_dietasglicogenios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_dietasglicogenios` (
  `idDietaGlicogenio` int(11) NOT NULL AUTO_INCREMENT,
  `IdAlimentoPosTreino` int(11) NOT NULL,
  `QtdRefeicaoCarboidrato` int(11) NOT NULL,
  `QtdRefeicaoProteina` int(11) NOT NULL,
  `QtdCarboidratoPorcento` float NOT NULL,
  `QtdProteinaPorcento` float NOT NULL,
  `QtdLipideoPorcento` float NOT NULL,
  `QtdCarboidratoGrama` float NOT NULL,
  `QtdProteinaGrama` float NOT NULL,
  `QtdLipideoGrama` float NOT NULL,
  `QtdGlicoMuscularMista` float NOT NULL,
  `QtdGlicoMuscularRicoCHO` float NOT NULL,
  `QtdGlicoMuscularPobreCHO` float NOT NULL,
  `QtdGlicoHepaticoMista` float NOT NULL,
  `QtdGlicoHepaticoRicoCHO` float NOT NULL,
  `QtdGlicoHepaticoPobreCHO` float NOT NULL,
  `QtdCarboPosTreino` float NOT NULL,
  `QtdAlimentoPosTreino` float DEFAULT NULL,
  `TotalCarboCHODia` float NOT NULL,
  `TotalProteinaCHODia` float NOT NULL,
  PRIMARY KEY (`idDietaGlicogenio`),
  KEY `IdAlimentoPosTreino` (`IdAlimentoPosTreino`),
  CONSTRAINT `tb_dietasglicogenios_ibfk_1` FOREIGN KEY (`IdAlimentoPosTreino`) REFERENCES `tb_alimentos` (`IdAlimento`)
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

-- Dump completed on 2017-07-20 14:08:50
