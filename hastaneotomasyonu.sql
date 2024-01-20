-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 28 Ara 2023, 13:31:43
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `hastaneotomasyonu`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bolumler`
--

CREATE TABLE `bolumler` (
  `Id` int(11) NOT NULL,
  `BolumAdi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `bolumler`
--

INSERT INTO `bolumler` (`Id`, `BolumAdi`) VALUES
(8, 'Çocuk Hastalıkları'),
(9, 'Dahiliye'),
(10, 'Radyoloji'),
(11, 'KKB'),
(12, 'KKB2'),
(13, 'Göz Hastalıkları'),
(14, 'Ortopedi'),
(15, 'Kardiyoloji'),
(16, 'Nöroloji'),
(17, 'Üroloji');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `doktorlar`
--

CREATE TABLE `doktorlar` (
  `Id` int(11) NOT NULL,
  `Isim` varchar(45) DEFAULT NULL,
  `Soyisim` varchar(45) DEFAULT NULL,
  `Tc` varchar(11) DEFAULT NULL,
  `Cinsiyet` varchar(45) DEFAULT NULL,
  `DogumTarihi` date DEFAULT NULL,
  `Bolum_Id` int(11) NOT NULL,
  `Telefon` varchar(11) DEFAULT NULL,
  `Sifre` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `doktorlar`
--

INSERT INTO `doktorlar` (`Id`, `Isim`, `Soyisim`, `Tc`, `Cinsiyet`, `DogumTarihi`, `Bolum_Id`, `Telefon`, `Sifre`) VALUES
(23, 'Ahmet', 'Yılmaz', '12345678900', 'Erkek', '1980-01-15', 8, '5551234567', 'ahmet123'),
(24, 'Merve', 'Demir', '23456789012', 'Kadın', '1985-05-20', 8, '5552345678', 'merve456'),
(25, 'Mustafa', 'Kaya', '34567890123', 'Erkek', '1990-09-25', 9, '5553456789', 'mustafa789'),
(26, 'Ayşe', 'Çelik', '45678901234', 'Kadın', '1982-03-10', 9, '5554567890', 'ayse234'),
(27, 'Eren', 'Yıldız', '56789012345', 'Erkek', '1987-11-02', 10, '5555678901', 'eren567'),
(29, 'Emre', 'Güneş', '78901234567', 'Erkek', '1989-12-05', 12, '5557890123', 'emre456'),
(30, 'İrem', 'Demirtaş', '89012345678', 'Kadın', '1986-04-30', 12, '5558901234', 'irem789'),
(31, 'Kaan', 'Toprak', '90123456789', 'Erkek', '1983-08-14', 10, '5559012345', 'kaan234'),
(32, 'Sevim', 'Kurt', '01234567890', 'Kadın', '1995-06-22', 10, '5550123456', 'sevim567');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `duyurular`
--

CREATE TABLE `duyurular` (
  `Id` int(11) NOT NULL,
  `Konu` varchar(50) DEFAULT NULL,
  `Duyuru` varchar(500) DEFAULT NULL,
  `Tarih` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `duyurular`
--

INSERT INTO `duyurular` (`Id`, `Konu`, `Duyuru`, `Tarih`) VALUES
(2, 'Hastane', 'koridor 1 muayne alanı 2 acil destek', '2023-12-17'),
(3, 'bölüm 1', 'Yeni stajyerimiz geldi.', '2023-12-18'),
(4, 'deneme', 'deneme123', '2023-12-21'),
(5, 'deneme', 'koridor 1 acilen boşaltılmalı', '2023-12-27');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hastalar`
--

CREATE TABLE `hastalar` (
  `Id` int(11) NOT NULL,
  `Isim` varchar(45) DEFAULT NULL,
  `Soyisim` varchar(45) DEFAULT NULL,
  `Tc` varchar(11) NOT NULL,
  `DogumTarihi` date DEFAULT NULL,
  `Cinsiyet` varchar(45) DEFAULT NULL,
  `Telefon` varchar(11) DEFAULT NULL,
  `Sifre` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `hastalar`
--

INSERT INTO `hastalar` (`Id`, `Isim`, `Soyisim`, `Tc`, `DogumTarihi`, `Cinsiyet`, `Telefon`, `Sifre`) VALUES
(4, 'Ali', 'Demir', '11111111111', '1990-03-12', 'Erkek', '5551112233', 'ali123'),
(5, 'Zeynep', 'Kara', '22222222222', '1988-07-28', 'Kadın', '5552223344', 'zeynep456'),
(6, 'Hüseyin', 'Yılmaz', '33333333333', '1992-11-05', 'Erkek', '5553334455', 'huseyin789'),
(7, 'Aysu', 'Arslan', '44444444444', '1987-05-19', 'Kadın', '5554445566', 'aysu234'),
(8, 'Kemal', 'Güneş', '55555555555', '1985-09-03', 'Erkek', '5555556677', 'kemal567'),
(9, 'Ceren', 'Demirtaş', '66666666666', '1991-12-20', 'Kadın', '5556667788', 'ceren901'),
(10, 'Yasin', 'Toprak', '77777777777', '1983-04-04', 'Erkek', '5557778899', 'yasin234'),
(11, 'Melis', 'Kurt', '88888888888', '1994-08-17', 'Kadın', '5558889000', 'melis567'),
(12, 'Berk', 'Çelik', '99999999999', '1989-02-10', 'Erkek', '5559990111', 'berk234'),
(13, 'Aylin', 'Yıldız', '00000000000', '1993-06-15', 'Kadın', '5550001222', 'aylin567'),
(14, 'Ersin', 'Ucar', '12547896587', '2005-05-05', 'Erkek', '05415258968', '123'),
(15, 'Ersin', 'Uçar', '12345678912', '2004-01-02', 'Erkek', '053361554', '1234'),
(16, 'efe', 'kürkçü', '12547885698', '2023-12-27', 'Erkek', '05415022555', '123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `randevular`
--

CREATE TABLE `randevular` (
  `Id` int(11) NOT NULL,
  `Isim` varchar(255) NOT NULL,
  `Soyisim` varchar(255) NOT NULL,
  `Bolum_Id` int(11) NOT NULL,
  `Sikayet` varchar(255) DEFAULT NULL,
  `doktor_id` int(11) NOT NULL,
  `Tarih` date NOT NULL,
  `Saat` varchar(45) NOT NULL,
  `hasta_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `randevular`
--

INSERT INTO `randevular` (`Id`, `Isim`, `Soyisim`, `Bolum_Id`, `Sikayet`, `doktor_id`, `Tarih`, `Saat`, `hasta_id`) VALUES
(20, 'Zeynep', 'Kara', 10, 'Ağrım var', 31, '2023-12-21', '09:00', 5),
(21, 'Ersin', 'Uçar', 8, ' öksürüyorum', 23, '2023-12-30', '11:00', 15),
(22, 'Ersin', 'Uçar', 8, 'dwqewqrwq', 23, '2023-12-21', '09:00', 15);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `receteler`
--

CREATE TABLE `receteler` (
  `id` int(11) NOT NULL,
  `doktor_id` int(11) DEFAULT NULL,
  `hasta_id` int(11) DEFAULT NULL,
  `icerik` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `receteler`
--

INSERT INTO `receteler` (`id`, `doktor_id`, `hasta_id`, `icerik`) VALUES
(9, 23, 15, 'Parol'),
(10, 32, 4, 'aspirin'),
(11, 23, 4, 'parol'),
(12, 23, 4, 'coldfen');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yoneticiler`
--

CREATE TABLE `yoneticiler` (
  `Id` int(11) NOT NULL,
  `Isim` varchar(45) DEFAULT NULL,
  `Soyisim` varchar(45) DEFAULT NULL,
  `Tc` varchar(11) DEFAULT NULL,
  `DogumTarihi` date DEFAULT NULL,
  `Telefon` varchar(11) DEFAULT NULL,
  `Cinsiyet` varchar(45) DEFAULT NULL,
  `Sifre` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `yoneticiler`
--

INSERT INTO `yoneticiler` (`Id`, `Isim`, `Soyisim`, `Tc`, `DogumTarihi`, `Telefon`, `Cinsiyet`, `Sifre`) VALUES
(3, 'Yusuf', 'Demir', '12345678911', '1990-05-10', '5551237890', 'Erkek', 'yonetici123'),
(4, 'Selin', 'Kara', '23456789012', '1988-09-15', '5552348901', 'Kadın', 'yonetici456'),
(5, 'Ahmet', 'Yılmaz', '34567890123', '1995-02-20', '5553459012', 'Erkek', 'yonetici789');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `bolumler`
--
ALTER TABLE `bolumler`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `doktorlar`
--
ALTER TABLE `doktorlar`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Doktorlar_Bolumler` (`Bolum_Id`);

--
-- Tablo için indeksler `duyurular`
--
ALTER TABLE `duyurular`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `hastalar`
--
ALTER TABLE `hastalar`
  ADD PRIMARY KEY (`Id`);

--
-- Tablo için indeksler `randevular`
--
ALTER TABLE `randevular`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `doktor_id` (`doktor_id`),
  ADD KEY `hasta_id` (`hasta_id`),
  ADD KEY `fk_randevular_bolumler` (`Bolum_Id`);

--
-- Tablo için indeksler `receteler`
--
ALTER TABLE `receteler`
  ADD PRIMARY KEY (`id`),
  ADD KEY `doktor_id` (`doktor_id`),
  ADD KEY `fk_receteler_hastalar` (`hasta_id`);

--
-- Tablo için indeksler `yoneticiler`
--
ALTER TABLE `yoneticiler`
  ADD PRIMARY KEY (`Id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `bolumler`
--
ALTER TABLE `bolumler`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Tablo için AUTO_INCREMENT değeri `doktorlar`
--
ALTER TABLE `doktorlar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- Tablo için AUTO_INCREMENT değeri `duyurular`
--
ALTER TABLE `duyurular`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `hastalar`
--
ALTER TABLE `hastalar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Tablo için AUTO_INCREMENT değeri `randevular`
--
ALTER TABLE `randevular`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Tablo için AUTO_INCREMENT değeri `receteler`
--
ALTER TABLE `receteler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Tablo için AUTO_INCREMENT değeri `yoneticiler`
--
ALTER TABLE `yoneticiler`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `doktorlar`
--
ALTER TABLE `doktorlar`
  ADD CONSTRAINT `FK_Doktorlar_Bolumler` FOREIGN KEY (`Bolum_Id`) REFERENCES `bolumler` (`Id`);

--
-- Tablo kısıtlamaları `randevular`
--
ALTER TABLE `randevular`
  ADD CONSTRAINT `fk_randevular_bolumler` FOREIGN KEY (`Bolum_Id`) REFERENCES `bolumler` (`Id`),
  ADD CONSTRAINT `randevular_ibfk_1` FOREIGN KEY (`doktor_id`) REFERENCES `doktorlar` (`Id`),
  ADD CONSTRAINT `randevular_ibfk_2` FOREIGN KEY (`hasta_id`) REFERENCES `hastalar` (`Id`);

--
-- Tablo kısıtlamaları `receteler`
--
ALTER TABLE `receteler`
  ADD CONSTRAINT `fk_receteler_hastalar` FOREIGN KEY (`hasta_id`) REFERENCES `hastalar` (`Id`),
  ADD CONSTRAINT `receteler_ibfk_1` FOREIGN KEY (`doktor_id`) REFERENCES `doktorlar` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
