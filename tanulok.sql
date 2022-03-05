-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 05. 16:39
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `tanulok`
--
CREATE DATABASE IF NOT EXISTS `tanulok` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `tanulok`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vizsga_keses`
--

CREATE TABLE IF NOT EXISTS `vizsga_keses` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tanuloID` int(11) NOT NULL,
  `mikor` date NOT NULL DEFAULT current_timestamp(),
  `igazolt` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `megjegyzes` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `tanuloID` (`tanuloID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vizsga_keses`
--

INSERT INTO `vizsga_keses` (`id`, `tanuloID`, `mikor`, `igazolt`, `megjegyzes`) VALUES
(1, 1, '2015-01-01', 'igen', 'vonatkésés'),
(5, 2, '2015-01-11', 'nem', 'elaludt'),
(7, 3, '2015-01-01', 'nem', 'elaludt');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vizsga_tanulo`
--

CREATE TABLE IF NOT EXISTS `vizsga_tanulo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vezeteknev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `keresztnev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `osztaly` varchar(4) COLLATE utf8_hungarian_ci NOT NULL,
  `ofo_neve` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vizsga_tanulo`
--

INSERT INTO `vizsga_tanulo` (`id`, `vezeteknev`, `keresztnev`, `osztaly`, `ofo_neve`) VALUES
(1, 'Kiss', 'Manyi', '11.A', 'Szigorú Elek'),
(2, 'Nagy', 'Imre', '12.A', 'Mérges Géza'),
(3, 'Tompa', 'Mihály', '11.B', 'Labor Ervin'),
(6, 'Teszt', 'Gabor', '12.A', 'Mérges Lajos');

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `vizsga_keses`
--
ALTER TABLE `vizsga_keses`
  ADD CONSTRAINT `FK_tanulo` FOREIGN KEY (`tanuloID`) REFERENCES `vizsga_tanulo` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
