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
-- Table structure for table `tb_avaliacoesfisicas`
--

DROP TABLE IF EXISTS `tb_avaliacoesfisicas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_avaliacoesfisicas` (
  `IdAvaliacaoFisica` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) NOT NULL,
  `NumrPeso` float NOT NULL,
  `NumrAltura` float NOT NULL,
  `NumrCircunferencia` float DEFAULT NULL,
  `QtdeMassaGorda` float DEFAULT NULL,
  `QtdeGordura` float DEFAULT NULL,
  `QtdeKclaDia` float DEFAULT NULL,
  `QtdeNAF` int(11) DEFAULT NULL,
  `IdObjetivoAluno` int(11) DEFAULT NULL,
  `IdAtividadeAluno` int(11) DEFAULT NULL,
  `SonoRegular` tinyint(1) DEFAULT NULL,
  `ProblemasArticulares` varchar(200) DEFAULT NULL,
  `MedicamentosAtuais` varchar(200) DEFAULT NULL,
  `AlergiaMedicamento` varchar(200) DEFAULT NULL,
  `AlunoPesoAcima` tinyint(1) DEFAULT NULL,
  `Observacao` varchar(800) DEFAULT NULL,
  `IdBioimpedancia` int(11) DEFAULT NULL,
  `Estatura` varchar(20) DEFAULT NULL,
  `MassaCorporal` float DEFAULT NULL,
  `Cintura` float DEFAULT NULL,
  `Quadril` float DEFAULT NULL,
  `Torax` float DEFAULT NULL,
  `Braco_D` float DEFAULT NULL,
  `Antebraco_D` float DEFAULT NULL,
  `Coxa_D` float DEFAULT NULL,
  `Perna` float DEFAULT NULL,
  `IMC` float DEFAULT NULL,
  `RCQ` float DEFAULT NULL,
  `FrequenciaRepouso` float DEFAULT NULL,
  `PASistolica` float DEFAULT NULL,
  `PADiastolica` float DEFAULT NULL,
  `Fumante` tinyint(1) DEFAULT NULL,
  `Diabetes` tinyint(1) DEFAULT NULL,
  `Colesterol` tinyint(1) DEFAULT NULL,
  `LDV_VLDL` tinyint(1) DEFAULT NULL,
  `DoencaCardioFamiliar` tinyint(1) DEFAULT NULL,
  `Cirurgia` tinyint(1) DEFAULT NULL,
  `DorPeito` tinyint(1) DEFAULT NULL,
  `FaltaDeAr` tinyint(1) DEFAULT NULL,
  `DoencaRespiratoria` tinyint(1) DEFAULT NULL,
  `DataInclusao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdAvaliacaoFisica`),
  KEY `IdObjetivoAluno` (`IdObjetivoAluno`),
  KEY `IdAtividadeAluno` (`IdAtividadeAluno`),
  KEY `IdBioimpedancia` (`IdBioimpedancia`),
  KEY `IdPessoa` (`IdPessoa`),
  CONSTRAINT `tb_avaliacoesfisicas_ibfk_1` FOREIGN KEY (`IdObjetivoAluno`) REFERENCES `tb_objetivosalunos` (`IdObjetivoAluno`),
  CONSTRAINT `tb_avaliacoesfisicas_ibfk_2` FOREIGN KEY (`IdAtividadeAluno`) REFERENCES `tb_atividadesalunos` (`IdAtividadeAluno`),
  CONSTRAINT `tb_avaliacoesfisicas_ibfk_3` FOREIGN KEY (`IdBioimpedancia`) REFERENCES `tb_bioimpedancias` (`IdBioimpedancia`),
  CONSTRAINT `tb_avaliacoesfisicas_ibfk_4` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoas` (`IdPessoa`)
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

-- Dump completed on 2017-07-20 14:08:54
