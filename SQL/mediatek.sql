-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 02 juin 2022 à 16:05
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int(11) NOT NULL,
  `datedebut` datetime NOT NULL,
  `idmotif` int(11) NOT NULL,
  `datefin` datetime DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `FK_absence_motif` (`idmotif`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `idmotif`, `datefin`) VALUES
(6, '2002-03-22 00:00:00', 2, '2023-07-22 00:00:00'),
(6, '2004-09-22 00:00:00', 2, '2014-02-22 00:00:00'),
(6, '2009-03-23 00:00:00', 1, '2024-12-22 00:00:00'),
(6, '2014-02-23 00:00:00', 3, '2015-07-21 00:00:00'),
(9, '2022-06-03 00:00:00', 1, '2022-06-15 00:00:00'),
(11, '2022-05-30 00:00:00', 4, '2022-06-06 00:00:00'),
(11, '2022-06-06 00:00:00', 3, '2022-06-08 00:00:00'),
(11, '2022-06-13 00:00:00', 1, '2022-06-27 00:00:00'),
(15, '2022-05-29 00:00:00', 4, '2022-06-25 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int(11) NOT NULL AUTO_INCREMENT,
  `idservice` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `FK_personnel_service` (`idservice`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `idservice`, `nom`, `prenom`, `tel`, `mail`) VALUES
(1, 2, 'Mendez', 'Beck', '0610183527', 'sit.amet@icloud.edu'),
(2, 2, 'Huber', 'Howard', '0856574849', 'nulla.tempor@protonmail.couk'),
(3, 2, 'Caldwell', 'Erin', '0446555518', 'nec.imperdiet@aol.com'),
(5, 1, 'Albert', 'Reece', '0769325685', 'euismod.mauris@aol.org'),
(6, 3, 'Hanna', 'Valencia', '0627017023', 'molestie.arcu@icloud.ca'),
(9, 2, 'Dupont', 'Antoine', '0653212147', 'antoined@gmail.com'),
(10, 2, 'Dupont', 'Clara', '0752639658', 'clarad@gmail.com'),
(11, 2, 'Delacroix', 'Mathieu', '0756395658', 'matdelacroix@gmail.com'),
(15, 2, 'Hanna', 'Pierre', '0686263512', 'pierre.hanna@icloud.ca'),
(29, 2, 'Hannon', 'Vincent', '0745236589', 'hannonn.vincent5233@outlook.com'),
(35, 1, 'Popczyk', 'Louise', '0652453625', 'popczyk.louise@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('mediatekadmin', 'e4bc29dc8068a4f8be92dff03fa14336d460bf5bb185a28f77b3afad8de4fce8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`idmotif`) REFERENCES `motif` (`idmotif`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`idpersonnel`) REFERENCES `personnel` (`idpersonnel`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`idservice`) REFERENCES `service` (`idservice`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
