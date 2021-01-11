-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Jan-2021 às 11:19
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.2.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `loja`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `tel` mediumtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id`, `nome`, `tel`) VALUES
(15, 'mauro', '1199999999'),
(16, 'cli', '324234234'),
(17, 'Julio', '1122454565'),
(18, 'teste', '5555555');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedidos`
--

CREATE TABLE `pedidos` (
  `id` int(11) NOT NULL,
  `idproduto` int(11) DEFAULT NULL,
  `idcliente` int(11) DEFAULT NULL,
  `nomecliente` varchar(50) DEFAULT NULL,
  `telcliente` mediumtext DEFAULT NULL,
  `nomeproduto` varchar(20) DEFAULT NULL,
  `marcaproduto` varchar(20) DEFAULT NULL,
  `tipoproduto` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pedidos`
--

INSERT INTO `pedidos` (`id`, `idproduto`, `idcliente`, `nomecliente`, `telcliente`, `nomeproduto`, `marcaproduto`, `tipoproduto`) VALUES
(4, 4, 16, 'cli', '324234234', 'produto1', 'Vans', 'Calça'),
(5, 4, 16, 'cli', '324234234', 'produto1', 'Vans', 'Calça'),
(6, 4, 15, 'mauro', '1199999999', 'produto1', 'Vans', 'Calça'),
(7, 10, 17, 'Julio', '1122454565', 'Calca', 'Vans', 'Calça'),
(8, 11, 18, 'teste', '5555555', 'teste', 'Vans', 'Shorts');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `marca` varchar(20) DEFAULT NULL,
  `tipo` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`id`, `nome`, `marca`, `tipo`) VALUES
(4, 'produto1', 'Vans', 'Calça'),
(8, 'teste', 'teste', 'Shorts'),
(9, 'teste2', 'Hurley', 'Calça'),
(10, 'Calca', 'Vans', 'Calça'),
(11, 'teste', 'Vans', 'Shorts'),
(12, '', '', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `nome` varchar(50) DEFAULT NULL,
  `usuario` varchar(50) DEFAULT NULL,
  `senha` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`nome`, `usuario`, `senha`) VALUES
('Julio', 'juliomig', '123'),
('vendedorteste', 'teste', '123'),
('Guilherme Souza', 'GuilhermeMGS1997', 'Gui@1234');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idproduto` (`idproduto`),
  ADD KEY `idcliente` (`idcliente`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`idproduto`) REFERENCES `produtos` (`id`),
  ADD CONSTRAINT `pedidos_ibfk_2` FOREIGN KEY (`idcliente`) REFERENCES `cliente` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
