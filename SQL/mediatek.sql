-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 28 mai 2022 à 01:43
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
(1, '2001-03-22 00:00:00', 1, '2027-04-22 00:00:00'),
(1, '2017-09-21 00:00:00', 1, '2027-01-22 00:00:00'),
(1, '2023-01-23 00:00:00', 2, '2029-08-22 00:00:00'),
(1, '2027-11-21 00:00:00', 1, '2019-02-22 00:00:00'),
(2, '2010-11-21 00:00:00', 2, '2025-12-21 00:00:00'),
(2, '2017-06-22 00:00:00', 3, '2003-08-22 00:00:00'),
(2, '2026-08-21 00:00:00', 3, '2014-08-22 00:00:00'),
(2, '2027-01-23 00:00:00', 3, '2027-11-21 00:00:00'),
(3, '2003-09-22 00:00:00', 1, '2012-08-21 00:00:00'),
(3, '2009-01-22 00:00:00', 2, '2022-01-22 00:00:00'),
(3, '2010-09-21 00:00:00', 1, '2003-09-21 00:00:00'),
(3, '2022-06-22 00:00:00', 2, '2002-02-22 00:00:00'),
(4, '2006-11-22 00:00:00', 1, '2015-12-21 00:00:00'),
(4, '2009-06-22 00:00:00', 2, '2008-12-21 00:00:00'),
(4, '2026-04-23 00:00:00', 2, '2001-12-21 00:00:00'),
(4, '2026-09-21 00:00:00', 1, '2031-12-22 00:00:00'),
(5, '2003-11-22 00:00:00', 3, '2028-11-21 00:00:00'),
(5, '2007-07-21 00:00:00', 3, '2029-08-21 00:00:00'),
(5, '2007-07-22 00:00:00', 3, '2023-02-22 00:00:00'),
(5, '2008-05-23 00:00:00', 2, '2007-07-22 00:00:00'),
(6, '2002-03-22 00:00:00', 2, '2023-07-22 00:00:00'),
(6, '2004-09-22 00:00:00', 2, '2014-02-22 00:00:00'),
(6, '2009-03-23 00:00:00', 1, '2024-12-22 00:00:00'),
(6, '2014-02-23 00:00:00', 3, '2015-07-21 00:00:00'),
(7, '2005-04-22 00:00:00', 2, '2019-06-21 00:00:00'),
(7, '2007-06-21 00:00:00', 1, '2008-08-21 00:00:00'),
(7, '2023-03-23 00:00:00', 2, '2024-11-22 00:00:00'),
(7, '2026-10-21 00:00:00', 3, '2020-07-22 00:00:00'),
(8, '2005-05-22 00:00:00', 2, '2028-06-22 00:00:00'),
(8, '2007-04-22 00:00:00', 3, '2010-05-22 00:00:00'),
(8, '2008-06-22 00:00:00', 3, '2025-12-22 00:00:00'),
(8, '2020-02-22 00:00:00', 2, '2022-12-22 00:00:00'),
(8, '2023-02-22 00:00:00', 2, '2007-03-23 00:00:00'),
(8, '2028-03-23 00:00:00', 2, '2015-01-22 00:00:00'),
(8, '2029-08-22 00:00:00', 3, '2005-08-21 00:00:00'),
(8, '2031-07-22 00:00:00', 1, '2027-02-22 00:00:00'),
(9, '2006-05-23 00:00:00', 2, '2027-04-23 00:00:00'),
(9, '2009-01-22 00:00:00', 2, '2010-03-22 00:00:00'),
(9, '2010-03-22 00:00:00', 2, '2009-02-23 00:00:00'),
(9, '2013-10-21 00:00:00', 3, '2012-07-21 00:00:00'),
(9, '2018-07-21 00:00:00', 2, '2022-09-22 00:00:00'),
(9, '2018-08-21 00:00:00', 3, '2021-11-21 00:00:00'),
(9, '2018-11-22 00:00:00', 1, '2014-05-22 00:00:00'),
(9, '2019-02-22 00:00:00', 2, '2025-01-23 00:00:00'),
(9, '2020-08-22 00:00:00', 3, '2012-09-21 00:00:00'),
(9, '2027-12-21 00:00:00', 2, '2016-10-21 00:00:00'),
(10, '2004-01-22 00:00:00', 1, '2014-12-21 00:00:00'),
(10, '2007-02-22 00:00:00', 1, '2018-11-22 00:00:00'),
(10, '2024-05-23 00:00:00', 2, '2029-11-22 00:00:00'),
(10, '2029-06-21 00:00:00', 1, '2021-05-23 00:00:00');

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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `idservice`, `nom`, `prenom`, `tel`, `mail`) VALUES
(1, 2, 'Jonas', 'Gibbs', '0617342028', 'proin.vel.nisl@protonmail.couk'),
(2, 2, 'Arthur', 'Lamb', '0642196421', 'senectus.et@protonmail.ca'),
(3, 3, 'Thane', 'Webster', '0624817515', 'consectetuer.adipiscing@aol.net'),
(4, 1, 'Noah', 'Palmer', '0634646853', 'magna.duis.dignissim@protonmail.couk'),
(5, 3, 'Wayne', 'Bender', '0682833183', 'neque.sed.dictum@protonmail.com'),
(6, 3, 'Hanna', 'Valencia', '0627017023', 'molestie.arcu@icloud.ca'),
(7, 2, 'Nyssa', 'Blanchard', '0675268184', 'eu.ultrices@yahoo.net'),
(8, 2, 'Rooney', 'Serrano', '0714249178', 'aliquet.libero@icloud.ca'),
(9, 2, 'Patrick', 'Galloway', '0642220533', 'dui@yahoo.org'),
(10, 2, 'Farrah', 'Ferguson', '0741212851', 'vulputate.ullamcorper.magna@icloud.org');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(255) NOT NULL,
  `pwd` varchar(255) NOT NULL
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
