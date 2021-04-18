CREATE DATABASE  IF NOT EXISTS `controlo_assiduidade` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `controlo_assiduidade`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: controlo_assiduidade
-- ------------------------------------------------------
-- Server version	5.7.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aula`
--

DROP TABLE IF EXISTS `aula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aula` (
  `aula_cod` varchar(10) NOT NULL,
  `cod_est` varchar(10) NOT NULL,
  `cod_doc` varchar(10) NOT NULL,
  `aula_data` date DEFAULT NULL,
  `aula_hora_inicio` timestamp(6) NULL DEFAULT NULL,
  `aula_hora_fim` timestamp(6) NULL DEFAULT NULL,
  PRIMARY KEY (`aula_cod`,`cod_est`,`cod_doc`),
  KEY `cod_est` (`cod_est`),
  KEY `cod_doc` (`cod_doc`),
  CONSTRAINT `aula_ibfk_1` FOREIGN KEY (`cod_est`) REFERENCES `estudante` (`est_cod`),
  CONSTRAINT `aula_ibfk_2` FOREIGN KEY (`cod_doc`) REFERENCES `docente` (`doc_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aula`
--

LOCK TABLES `aula` WRITE;
/*!40000 ALTER TABLE `aula` DISABLE KEYS */;
/*!40000 ALTER TABLE `aula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso`
--

DROP TABLE IF EXISTS `curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `curso` (
  `curso_cod` varchar(10) NOT NULL,
  `curso_nome` varchar(30) DEFAULT NULL,
  `curso_duracao` varchar(10) DEFAULT NULL,
  `curso_descricao` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`curso_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso`
--

LOCK TABLES `curso` WRITE;
/*!40000 ALTER TABLE `curso` DISABLE KEYS */;
/*!40000 ALTER TABLE `curso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso_disciplina`
--

DROP TABLE IF EXISTS `curso_disciplina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `curso_disciplina` (
  `cod_curso` varchar(10) NOT NULL,
  `cod_disc` varchar(10) NOT NULL,
  PRIMARY KEY (`cod_curso`,`cod_disc`),
  KEY `cod_disc` (`cod_disc`),
  CONSTRAINT `curso_disciplina_ibfk_1` FOREIGN KEY (`cod_curso`) REFERENCES `curso` (`curso_cod`),
  CONSTRAINT `curso_disciplina_ibfk_2` FOREIGN KEY (`cod_disc`) REFERENCES `disciplina` (`disc_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso_disciplina`
--

LOCK TABLES `curso_disciplina` WRITE;
/*!40000 ALTER TABLE `curso_disciplina` DISABLE KEYS */;
/*!40000 ALTER TABLE `curso_disciplina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disciplina`
--

DROP TABLE IF EXISTS `disciplina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `disciplina` (
  `disc_cod` varchar(10) NOT NULL,
  `disc_nome` varchar(20) DEFAULT NULL,
  `disc_carga_horaria` varchar(10) DEFAULT NULL,
  `disc_estatuto` varchar(10) DEFAULT NULL,
  `disc_credito` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`disc_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disciplina`
--

LOCK TABLES `disciplina` WRITE;
/*!40000 ALTER TABLE `disciplina` DISABLE KEYS */;
/*!40000 ALTER TABLE `disciplina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `docente`
--

DROP TABLE IF EXISTS `docente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `docente` (
  `doc_cod` varchar(10) NOT NULL,
  `doc_primeiro_nome` varchar(30) NOT NULL,
  `doc_ultimo_nome` varchar(20) DEFAULT NULL,
  `doc_genero` char(1) DEFAULT NULL,
  `doc_data_nasc` date DEFAULT NULL,
  `doc_estado_civil` varchar(10) DEFAULT NULL,
  `doc_naturalidade` varchar(20) DEFAULT NULL,
  `doc_data_ingresso` date DEFAULT NULL,
  `doc_identidade_tipo` varchar(20) DEFAULT NULL,
  `doc_identidade_numero` varchar(12) DEFAULT NULL,
  `doc_email` varchar(50) DEFAULT NULL,
  `doc_telef1` varchar(12) DEFAULT NULL,
  `doc_telef2` varchar(12) DEFAULT NULL,
  `doc_cidade` varchar(20) DEFAULT NULL,
  `doc_localidade` varchar(20) DEFAULT NULL,
  `doc_bairro` varchar(20) DEFAULT NULL,
  `doc_quarteirao` int(11) DEFAULT NULL,
  `doc_numero_casa` int(11) DEFAULT NULL,
  `doc_formacao` varchar(50) DEFAULT NULL,
  `cod_disc` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`doc_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `docente`
--

LOCK TABLES `docente` WRITE;
/*!40000 ALTER TABLE `docente` DISABLE KEYS */;
/*!40000 ALTER TABLE `docente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudante`
--

DROP TABLE IF EXISTS `estudante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estudante` (
  `est_cod` varchar(10) NOT NULL,
  `est_primeiro_nome` varchar(30) NOT NULL,
  `est_ultimo_nome` varchar(20) DEFAULT NULL,
  `est_genero` char(1) DEFAULT NULL,
  `est_data_nasc` date DEFAULT NULL,
  `est_estado_civil` varchar(10) DEFAULT NULL,
  `est_nacionalidade` varchar(30) DEFAULT NULL,
  `est_naturalidade` varchar(20) DEFAULT NULL,
  `est_data_ingresso` date DEFAULT NULL,
  `est_identidade_tipo` varchar(20) DEFAULT NULL,
  `est_identidade_numero` varchar(12) DEFAULT NULL,
  `est_email` varchar(50) DEFAULT NULL,
  `est_telef1` varchar(12) DEFAULT NULL,
  `est_telef2` varchar(12) DEFAULT NULL,
  `est_cidade` varchar(20) DEFAULT NULL,
  `est_localidade` varchar(20) DEFAULT NULL,
  `est_bairro` varchar(20) DEFAULT NULL,
  `est_quarteirao` int(11) DEFAULT NULL,
  `est_numero_casa` int(11) DEFAULT NULL,
  `cod_curso` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`est_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudante`
--

LOCK TABLES `estudante` WRITE;
/*!40000 ALTER TABLE `estudante` DISABLE KEYS */;
/*!40000 ALTER TABLE `estudante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala`
--

DROP TABLE IF EXISTS `sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sala` (
  `sala_cod` varchar(10) NOT NULL,
  `sala_lotacao` varchar(300) DEFAULT NULL,
  `sala_celula` varchar(4) DEFAULT NULL,
  `sala_pavilhao` varchar(4) DEFAULT NULL,
  `sala_piso` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`sala_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turma`
--

DROP TABLE IF EXISTS `turma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `turma` (
  `turma_cod` varchar(10) NOT NULL,
  `turma_regime` varchar(20) DEFAULT NULL,
  `turma_capacidade` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`turma_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turma`
--

LOCK TABLES `turma` WRITE;
/*!40000 ALTER TABLE `turma` DISABLE KEYS */;
/*!40000 ALTER TABLE `turma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turma_ocupada`
--

DROP TABLE IF EXISTS `turma_ocupada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `turma_ocupada` (
  `cod_turma` varchar(10) NOT NULL,
  `cod_est` varchar(10) NOT NULL,
  `cod_sala` varchar(10) NOT NULL,
  PRIMARY KEY (`cod_turma`,`cod_est`,`cod_sala`),
  KEY `cod_est` (`cod_est`),
  KEY `cod_sala` (`cod_sala`),
  CONSTRAINT `turma_ocupada_ibfk_1` FOREIGN KEY (`cod_turma`) REFERENCES `turma` (`turma_cod`),
  CONSTRAINT `turma_ocupada_ibfk_2` FOREIGN KEY (`cod_est`) REFERENCES `estudante` (`est_cod`),
  CONSTRAINT `turma_ocupada_ibfk_3` FOREIGN KEY (`cod_sala`) REFERENCES `sala` (`sala_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turma_ocupada`
--

LOCK TABLES `turma_ocupada` WRITE;
/*!40000 ALTER TABLE `turma_ocupada` DISABLE KEYS */;
/*!40000 ALTER TABLE `turma_ocupada` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-12 15:27:03
