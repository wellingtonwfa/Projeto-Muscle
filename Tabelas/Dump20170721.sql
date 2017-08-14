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
-- Dumping data for table `tb_alimentos`
--

LOCK TABLES `tb_alimentos` WRITE;
/*!40000 ALTER TABLE `tb_alimentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_alimentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_atividades`
--

LOCK TABLES `tb_atividades` WRITE;
/*!40000 ALTER TABLE `tb_atividades` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_atividades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_atividadesalunos`
--

LOCK TABLES `tb_atividadesalunos` WRITE;
/*!40000 ALTER TABLE `tb_atividadesalunos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_atividadesalunos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_avaliacoesfisicas`
--

LOCK TABLES `tb_avaliacoesfisicas` WRITE;
/*!40000 ALTER TABLE `tb_avaliacoesfisicas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_avaliacoesfisicas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_bioimpedancias`
--

LOCK TABLES `tb_bioimpedancias` WRITE;
/*!40000 ALTER TABLE `tb_bioimpedancias` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_bioimpedancias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_cardapios`
--

LOCK TABLES `tb_cardapios` WRITE;
/*!40000 ALTER TABLE `tb_cardapios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cardapios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_contatos`
--

LOCK TABLES `tb_contatos` WRITE;
/*!40000 ALTER TABLE `tb_contatos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_contatos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_dietas`
--

LOCK TABLES `tb_dietas` WRITE;
/*!40000 ALTER TABLE `tb_dietas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_dietas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_dietascalorimetrias`
--

LOCK TABLES `tb_dietascalorimetrias` WRITE;
/*!40000 ALTER TABLE `tb_dietascalorimetrias` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_dietascalorimetrias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_dietascicloscarbos`
--

LOCK TABLES `tb_dietascicloscarbos` WRITE;
/*!40000 ALTER TABLE `tb_dietascicloscarbos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_dietascicloscarbos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_dietasglicogenios`
--

LOCK TABLES `tb_dietasglicogenios` WRITE;
/*!40000 ALTER TABLE `tb_dietasglicogenios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_dietasglicogenios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_dobrascutaneas`
--

LOCK TABLES `tb_dobrascutaneas` WRITE;
/*!40000 ALTER TABLE `tb_dobrascutaneas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_dobrascutaneas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_itenscardapios`
--

LOCK TABLES `tb_itenscardapios` WRITE;
/*!40000 ALTER TABLE `tb_itenscardapios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_itenscardapios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_objetivonutricional`
--

LOCK TABLES `tb_objetivonutricional` WRITE;
/*!40000 ALTER TABLE `tb_objetivonutricional` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_objetivonutricional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_objetivos`
--

LOCK TABLES `tb_objetivos` WRITE;
/*!40000 ALTER TABLE `tb_objetivos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_objetivos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_objetivosalunos`
--

LOCK TABLES `tb_objetivosalunos` WRITE;
/*!40000 ALTER TABLE `tb_objetivosalunos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_objetivosalunos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_objetivosperdas`
--

LOCK TABLES `tb_objetivosperdas` WRITE;
/*!40000 ALTER TABLE `tb_objetivosperdas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_objetivosperdas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_pessoas`
--

LOCK TABLES `tb_pessoas` WRITE;
/*!40000 ALTER TABLE `tb_pessoas` DISABLE KEYS */;
INSERT INTO `tb_pessoas` VALUES (1,'Teste Teste','00259923176','1984-09-16','M','Solteiro','Analista','Rua 1','Goiania','Goias','2017-07-20 16:09:43');
/*!40000 ALTER TABLE `tb_pessoas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_tipoalimentos`
--

LOCK TABLES `tb_tipoalimentos` WRITE;
/*!40000 ALTER TABLE `tb_tipoalimentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_tipoalimentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_tiporefeicao`
--

LOCK TABLES `tb_tiporefeicao` WRITE;
/*!40000 ALTER TABLE `tb_tiporefeicao` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_tiporefeicao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_usuarios`
--

LOCK TABLES `tb_usuarios` WRITE;
/*!40000 ALTER TABLE `tb_usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_valoresdobrascutaneas`
--

LOCK TABLES `tb_valoresdobrascutaneas` WRITE;
/*!40000 ALTER TABLE `tb_valoresdobrascutaneas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_valoresdobrascutaneas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-21 18:00:25
