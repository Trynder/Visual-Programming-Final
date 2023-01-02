-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2023, 21:16:31
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `belediye1`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `anaekran`
--

CREATE TABLE `anaekran` (
  `id` int(11) NOT NULL,
  `asfalt` varchar(50) NOT NULL,
  `alan` varchar(50) NOT NULL,
  `proje` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `anaekran`
--

INSERT INTO `anaekran` (`id`, `asfalt`, `alan`, `proje`) VALUES
(1, '1988km', '550km', '5');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `baskan`
--

CREATE TABLE `baskan` (
  `baskan_id` int(11) NOT NULL,
  `baskan_ad` varchar(25) NOT NULL,
  `baskan_soyad` varchar(25) NOT NULL,
  `baskan_bilgiler` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `baskan`
--

INSERT INTO `baskan` (`baskan_id`, `baskan_ad`, `baskan_soyad`, `baskan_bilgiler`) VALUES
(1, 'Murat', 'SARI', 'Akademisyen ');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `borc`
--

CREATE TABLE `borc` (
  `borc_id` int(11) NOT NULL,
  `tel_no` varchar(50) NOT NULL,
  `su_borc` varchar(50) NOT NULL,
  `dgz_borc` varchar(50) NOT NULL,
  `elektrik_borc` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `borc`
--

INSERT INTO `borc` (`borc_id`, `tel_no`, `su_borc`, `dgz_borc`, `elektrik_borc`) VALUES
(1, '555', '150', '300', '0');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `haberler`
--

CREATE TABLE `haberler` (
  `haber_id` int(11) NOT NULL,
  `haber_baslik` varchar(100) NOT NULL,
  `haber_text` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `haberler`
--

INSERT INTO `haberler` (`haber_id`, `haber_baslik`, `haber_text`) VALUES
(1, 'Şanlı Balıkesir şaha kalkıyor!', 'Balıkesir\'de yaşanan sel felaketinden sonra insanlar oranın kötüye gideceğini düşündü'),
(2, 'Adana\'da insanlar güneşe ateş ediyor!', 'Adana\'da sıradan bir gün yaşanıyor.');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `iletisim`
--

CREATE TABLE `iletisim` (
  `iletisim_id` int(11) NOT NULL,
  `gsm` varchar(50) NOT NULL,
  `adres` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `iletisim`
--

INSERT INTO `iletisim` (`iletisim_id`, `gsm`, `adres`) VALUES
(0, '55555', 'meydan');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `tel_no` int(12) NOT NULL,
  `sifre` varchar(50) NOT NULL,
  `su_borcu` int(50) NOT NULL,
  `elektrik_borcu` int(50) NOT NULL,
  `dgz_borcu` int(50) NOT NULL,
  `yetki` int(25) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `login`
--

INSERT INTO `login` (`id`, `tel_no`, `sifre`, `su_borcu`, `elektrik_borcu`, `dgz_borcu`, `yetki`) VALUES
(1, 1233, '1233', 0, 0, 0, 0),
(3, 321, '321', 0, 0, 0, 0),
(4, 432, '432', 0, 0, 0, 0),
(5, 654, '865', 0, 0, 0, 0),
(6, 1, '1', 0, 0, 0, 1),
(7, 555, '123', 234, 0, 0, 1),
(8, 544952, '1212', 0, 0, 0, 0),
(9, 1, '1', 0, 0, 0, 0),
(10, 567, '789', 0, 0, 0, 0),
(11, 5454, '44', 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `oto_saat`
--

CREATE TABLE `oto_saat` (
  `id` int(11) NOT NULL,
  `saat1` varchar(50) NOT NULL,
  `saat2` varchar(50) NOT NULL,
  `saat3` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `oto_saat`
--

INSERT INTO `oto_saat` (`id`, `saat1`, `saat2`, `saat3`) VALUES
(2, '9', '9', '9');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `projeler`
--

CREATE TABLE `projeler` (
  `proje_id` int(11) NOT NULL,
  `devameden` varchar(100) NOT NULL,
  `tamamlanmıs` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `projeler`
--

INSERT INTO `projeler` (`proje_id`, `devameden`, `tamamlanmıs`) VALUES
(1, 'Kanal Projesi ', 'Su Parkı projesi'),
(2, 'Semt Balıkesir Projesi', 'Güzel Balıkesir Projesi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sehir`
--

CREATE TABLE `sehir` (
  `sehir_id` int(11) NOT NULL,
  `yer` varchar(50) NOT NULL,
  `ozellik` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sehir`
--

INSERT INTO `sehir` (`sehir_id`, `yer`, `ozellik`) VALUES
(1, 'Nizamiye Çeşme', '1886 yılında kurulan bu çeşme..'),
(2, 'Şehzade Camii ', 'Şehzadeler için yapılan bir mescit...'),
(3, 'Sultan Ahmed', 'Osm. zamanında inşa edilen bu yer ...');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `vefat`
--

CREATE TABLE `vefat` (
  `id` int(11) NOT NULL,
  `isim` varchar(31) NOT NULL,
  `soyisim` varchar(31) NOT NULL,
  `tarih` varchar(50) NOT NULL DEFAULT 'tarih'
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `vefat`
--

INSERT INTO `vefat` (`id`, `isim`, `soyisim`, `tarih`) VALUES
(1, 'abdulcelil', 'candan', '2022-12-29'),
(2, 'özgür', 'özdemmir', '2022-12-22'),
(11, 'asda', 'asfsa', '22-12-2022'),
(12, 'ali', 'gündoğdu', '29-12-2022'),
(13, 'furkan', 'özdemircan', '31-12-2022'),
(14, 'sinan', 'boztaş', '31.12.2022'),
(15, 'Muslih', 'abdiker', '1-1-2023'),
(16, 'sdvsb', 'bfsbfs', '2-1-2023'),
(17, 'Murat ', 'SARI', '2-1-2023');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `anaekran`
--
ALTER TABLE `anaekran`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `baskan`
--
ALTER TABLE `baskan`
  ADD PRIMARY KEY (`baskan_id`);

--
-- Tablo için indeksler `borc`
--
ALTER TABLE `borc`
  ADD PRIMARY KEY (`borc_id`);

--
-- Tablo için indeksler `haberler`
--
ALTER TABLE `haberler`
  ADD PRIMARY KEY (`haber_id`);

--
-- Tablo için indeksler `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `oto_saat`
--
ALTER TABLE `oto_saat`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `projeler`
--
ALTER TABLE `projeler`
  ADD PRIMARY KEY (`proje_id`);

--
-- Tablo için indeksler `sehir`
--
ALTER TABLE `sehir`
  ADD PRIMARY KEY (`sehir_id`);

--
-- Tablo için indeksler `vefat`
--
ALTER TABLE `vefat`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `anaekran`
--
ALTER TABLE `anaekran`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `baskan`
--
ALTER TABLE `baskan`
  MODIFY `baskan_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `borc`
--
ALTER TABLE `borc`
  MODIFY `borc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `haberler`
--
ALTER TABLE `haberler`
  MODIFY `haber_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `oto_saat`
--
ALTER TABLE `oto_saat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `projeler`
--
ALTER TABLE `projeler`
  MODIFY `proje_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `sehir`
--
ALTER TABLE `sehir`
  MODIFY `sehir_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `vefat`
--
ALTER TABLE `vefat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
