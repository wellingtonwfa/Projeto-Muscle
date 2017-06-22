-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 22-Jun-2017 às 16:24
-- Versão do servidor: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `assistencia`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_contatos`
--

CREATE TABLE `tb_contatos` (
  `IdContato` int(11) NOT NULL,
  `IdPessoa` int(11) DEFAULT NULL,
  `TipoContato` int(11) NOT NULL,
  `DescContato` varchar(200) NOT NULL,
  `DataInclusao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pessoas`
--

CREATE TABLE `tb_pessoas` (
  `IdPessoa` int(11) NOT NULL,
  `NomePessoa` varchar(20) NOT NULL,
  `CPF` varchar(20) NOT NULL,
  `Data_Nascimento` date NOT NULL,
  `Sexo` char(1) NOT NULL,
  `Estado_Civil` int(11) NOT NULL,
  `Profissao` varchar(200) DEFAULT NULL,
  `Logradouro` varchar(100) DEFAULT NULL,
  `Cidade` varchar(100) DEFAULT NULL,
  `Estado` varchar(20) DEFAULT NULL,
  `DataInclusao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_contatos`
--
ALTER TABLE `tb_contatos`
  ADD PRIMARY KEY (`IdContato`),
  ADD KEY `IdPessoa` (`IdPessoa`);

--
-- Indexes for table `tb_pessoas`
--
ALTER TABLE `tb_pessoas`
  ADD PRIMARY KEY (`IdPessoa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_contatos`
--
ALTER TABLE `tb_contatos`
  MODIFY `IdContato` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_pessoas`
--
ALTER TABLE `tb_pessoas`
  MODIFY `IdPessoa` int(11) NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_contatos`
--
ALTER TABLE `tb_contatos`
  ADD CONSTRAINT `tb_contatos_ibfk_1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoas` (`IdPessoa`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
