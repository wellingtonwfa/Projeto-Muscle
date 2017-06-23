-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 23-Jun-2017 às 19:54
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
-- Estrutura da tabela `tb_alimentos`
--

CREATE TABLE `tb_alimentos` (
  `IdAlimento` int(11) NOT NULL,
  `IdTipoAlimento` int(11) DEFAULT NULL,
  `NomeAlimento` varchar(200) NOT NULL,
  `QtdProteina` int(11) DEFAULT NULL,
  `QtdLipideo` int(11) DEFAULT NULL,
  `QtdCarboidrato` int(11) DEFAULT NULL,
  `DataInclusao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_complementosdietas`
--

CREATE TABLE `tb_complementosdietas` (
  `IdComplementoDieta` int(11) NOT NULL,
  `IdDieta` int(11) DEFAULT NULL,
  `Nome` varchar(20) NOT NULL,
  `Lipideos` varchar(20) DEFAULT NULL,
  `Caloria` varchar(20) DEFAULT NULL,
  `Carboidrato` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
-- Estrutura da tabela `tb_dietas`
--

CREATE TABLE `tb_dietas` (
  `IdDieta` int(11) NOT NULL,
  `IdPessoa` int(11) NOT NULL,
  `Ordem` int(11) NOT NULL,
  `TotalKcal` varchar(1000) NOT NULL,
  `TotalCarboidrato` varchar(1000) NOT NULL,
  `TotalLipideos` varchar(1000) NOT NULL,
  `DataInclusao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_itensdietas`
--

CREATE TABLE `tb_itensdietas` (
  `IdItemDieta` int(11) NOT NULL,
  `IdDieta` int(11) NOT NULL,
  `IdTipoRefeicao` int(11) NOT NULL,
  `IdAlimento` int(11) NOT NULL,
  `OrdemItem` int(11) NOT NULL,
  `Quantidade` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_objetivonutricional`
--

CREATE TABLE `tb_objetivonutricional` (
  `IdObjetivoNutricional` int(11) NOT NULL,
  `IdPessoa` int(11) NOT NULL,
  `CarboidratoPerc` varchar(20) NOT NULL,
  `CarboidratoGrama` varchar(20) NOT NULL,
  `ProteinaPerc` varchar(20) NOT NULL,
  `ProteinaGrama` varchar(20) NOT NULL,
  `LipideosPerc` varchar(20) NOT NULL,
  `LipideosGrama` varchar(20) NOT NULL
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
  `Estado_Civil` varchar(100) NOT NULL,
  `Profissao` varchar(200) DEFAULT NULL,
  `Logradouro` varchar(100) DEFAULT NULL,
  `Cidade` varchar(100) DEFAULT NULL,
  `Estado` varchar(20) DEFAULT NULL,
  `DataInclusao` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_pessoas`
--

INSERT INTO `tb_pessoas` (`IdPessoa`, `NomePessoa`, `CPF`, `Data_Nascimento`, `Sexo`, `Estado_Civil`, `Profissao`, `Logradouro`, `Cidade`, `Estado`, `DataInclusao`) VALUES
(1, 'wellington araujo', '00259923176', '1984-01-10', 'M', 'SOLTEIRO', '', '', '', '', '2017-06-23 03:00:00'),
(2, 'HANNA ARAUJO', '01130733130', '1993-09-27', 'F', 'CASADA', '', '', '', '', '2017-06-23 16:44:43'),
(3, 'TESTE TESTE', '12345678956', '1999-01-09', 'M', 'SOLTEIRO', NULL, NULL, NULL, NULL, '2017-06-23 16:47:10'),
(4, 'TESTE TESTE 02', '15684889945', '1995-04-21', 'M', 'SOLTEIRO', NULL, NULL, NULL, NULL, '2017-06-23 16:50:56');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tipoalimentos`
--

CREATE TABLE `tb_tipoalimentos` (
  `IdTipoAlimento` int(11) NOT NULL,
  `NomeTipoAlimento` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tiporefeicao`
--

CREATE TABLE `tb_tiporefeicao` (
  `IdTipoRefeicao` int(11) NOT NULL,
  `NomeRefeicao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_tiporefeicao`
--

INSERT INTO `tb_tiporefeicao` (`IdTipoRefeicao`, `NomeRefeicao`) VALUES
(1, 'ALMOÇO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `idUsuario` int(11) NOT NULL,
  `NomeUsuario` varchar(220) NOT NULL,
  `CPF` varchar(11) NOT NULL,
  `Senha` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_alimentos`
--
ALTER TABLE `tb_alimentos`
  ADD PRIMARY KEY (`IdAlimento`),
  ADD KEY `IdTipoAlimento` (`IdTipoAlimento`);

--
-- Indexes for table `tb_complementosdietas`
--
ALTER TABLE `tb_complementosdietas`
  ADD PRIMARY KEY (`IdComplementoDieta`),
  ADD KEY `IdDieta` (`IdDieta`);

--
-- Indexes for table `tb_contatos`
--
ALTER TABLE `tb_contatos`
  ADD PRIMARY KEY (`IdContato`),
  ADD KEY `IdPessoa` (`IdPessoa`);

--
-- Indexes for table `tb_dietas`
--
ALTER TABLE `tb_dietas`
  ADD PRIMARY KEY (`IdDieta`),
  ADD KEY `IdPessoa` (`IdPessoa`);

--
-- Indexes for table `tb_itensdietas`
--
ALTER TABLE `tb_itensdietas`
  ADD PRIMARY KEY (`IdItemDieta`),
  ADD KEY `IdDieta` (`IdDieta`),
  ADD KEY `IdTipoRefeicao` (`IdTipoRefeicao`),
  ADD KEY `IdAlimento` (`IdAlimento`);

--
-- Indexes for table `tb_objetivonutricional`
--
ALTER TABLE `tb_objetivonutricional`
  ADD PRIMARY KEY (`IdObjetivoNutricional`),
  ADD KEY `IdPessoa` (`IdPessoa`);

--
-- Indexes for table `tb_pessoas`
--
ALTER TABLE `tb_pessoas`
  ADD PRIMARY KEY (`IdPessoa`);

--
-- Indexes for table `tb_tipoalimentos`
--
ALTER TABLE `tb_tipoalimentos`
  ADD PRIMARY KEY (`IdTipoAlimento`);

--
-- Indexes for table `tb_tiporefeicao`
--
ALTER TABLE `tb_tiporefeicao`
  ADD PRIMARY KEY (`IdTipoRefeicao`);

--
-- Indexes for table `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`idUsuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_alimentos`
--
ALTER TABLE `tb_alimentos`
  MODIFY `IdAlimento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_complementosdietas`
--
ALTER TABLE `tb_complementosdietas`
  MODIFY `IdComplementoDieta` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_contatos`
--
ALTER TABLE `tb_contatos`
  MODIFY `IdContato` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_dietas`
--
ALTER TABLE `tb_dietas`
  MODIFY `IdDieta` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_itensdietas`
--
ALTER TABLE `tb_itensdietas`
  MODIFY `IdItemDieta` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_objetivonutricional`
--
ALTER TABLE `tb_objetivonutricional`
  MODIFY `IdObjetivoNutricional` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_pessoas`
--
ALTER TABLE `tb_pessoas`
  MODIFY `IdPessoa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tb_tipoalimentos`
--
ALTER TABLE `tb_tipoalimentos`
  MODIFY `IdTipoAlimento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_tiporefeicao`
--
ALTER TABLE `tb_tiporefeicao`
  MODIFY `IdTipoRefeicao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_alimentos`
--
ALTER TABLE `tb_alimentos`
  ADD CONSTRAINT `tb_alimentos_ibfk_1` FOREIGN KEY (`IdTipoAlimento`) REFERENCES `tb_tipoalimentos` (`IdTipoAlimento`);

--
-- Limitadores para a tabela `tb_complementosdietas`
--
ALTER TABLE `tb_complementosdietas`
  ADD CONSTRAINT `tb_complementosdietas_ibfk_1` FOREIGN KEY (`IdDieta`) REFERENCES `tb_dietas` (`IdDieta`);

--
-- Limitadores para a tabela `tb_contatos`
--
ALTER TABLE `tb_contatos`
  ADD CONSTRAINT `tb_contatos_ibfk_1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoas` (`IdPessoa`);

--
-- Limitadores para a tabela `tb_dietas`
--
ALTER TABLE `tb_dietas`
  ADD CONSTRAINT `tb_dietas_ibfk_1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoas` (`IdPessoa`);

--
-- Limitadores para a tabela `tb_itensdietas`
--
ALTER TABLE `tb_itensdietas`
  ADD CONSTRAINT `tb_itensdietas_ibfk_1` FOREIGN KEY (`IdDieta`) REFERENCES `tb_dietas` (`IdDieta`),
  ADD CONSTRAINT `tb_itensdietas_ibfk_2` FOREIGN KEY (`IdDieta`) REFERENCES `tb_dietas` (`IdDieta`),
  ADD CONSTRAINT `tb_itensdietas_ibfk_3` FOREIGN KEY (`IdTipoRefeicao`) REFERENCES `tb_tiporefeicao` (`IdTipoRefeicao`),
  ADD CONSTRAINT `tb_itensdietas_ibfk_4` FOREIGN KEY (`IdAlimento`) REFERENCES `tb_alimentos` (`IdAlimento`);

--
-- Limitadores para a tabela `tb_objetivonutricional`
--
ALTER TABLE `tb_objetivonutricional`
  ADD CONSTRAINT `tb_objetivonutricional_ibfk_1` FOREIGN KEY (`IdPessoa`) REFERENCES `tb_pessoas` (`IdPessoa`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
