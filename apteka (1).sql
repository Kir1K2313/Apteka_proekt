-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Фев 27 2024 г., 17:14
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `apteka`
--

-- --------------------------------------------------------

--
-- Структура таблицы `design`
--

CREATE TABLE IF NOT EXISTS `design` (
  `type` varchar(100) NOT NULL,
  `parametr` varchar(100) NOT NULL,
  `value` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `design`
--

INSERT INTO `design` (`type`, `parametr`, `value`) VALUES
('System.Windows.Forms.Label', 'FONT', 'Microsoft Sans Serif;14,25'),
('System.Windows.Forms.Label', 'FONT_COLOR', '-16776961'),
('System.Windows.Forms.Panel', 'PANEL_COLOR', '-256'),
('System.Windows.Forms.TextBox', 'FONT', 'Microsoft Sans Serif;14,25'),
('System.Windows.Forms.TextBox', 'FORECOLOR', '-16711681'),
('System.Windows.Forms.TextBox', 'BACK_COLOR', '-65536'),
('System.Windows.Forms.Button', 'FONT', 'Microsoft Sans Serif;14,25'),
('System.Windows.Forms.Button', 'FORECOLOR', '-16777088'),
('System.Windows.Forms.Button', 'BACK_COLOR', '-32768');

-- --------------------------------------------------------

--
-- Структура таблицы `level1`
--

CREATE TABLE IF NOT EXISTS `level1` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `adress` varchar(200) NOT NULL,
  `pic` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `level1`
--

INSERT INTO `level1` (`id`, `name`, `adress`, `pic`) VALUES
(1, 'Аптека №1', '', 'Аптека1.jpg'),
(2, 'Аптека №2', '', 'Аптека2.jpg'),
(3, 'Аптека №3', '', 'Здравсити.jpg'),
(4, 'Аптека №4', '', 'Планета здоровья.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `level2`
--

CREATE TABLE IF NOT EXISTS `level2` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `id_apteka` int(11) NOT NULL,
  `pic` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=14 ;

--
-- Дамп данных таблицы `level2`
--

INSERT INTO `level2` (`id`, `name`, `id_apteka`, `pic`) VALUES
(1, 'Таблетки', 1, '3.jpg'),
(2, 'Мази', 1, '2.jpg'),
(3, 'Антибиотики', 1, '1.jpg'),
(4, 'Таблетки', 2, '3.jpg'),
(5, 'Антибиотики', 2, '1.jpg'),
(6, 'Мази', 2, '2.jpg'),
(7, 'Таблетки', 3, '3.jpg'),
(8, 'Мази', 3, '2.jpg'),
(10, 'Антибиотики ', 3, '1.jpg'),
(11, 'Таблетки', 4, '3.jpg'),
(12, 'Антибиотики ', 4, '1.jpg'),
(13, 'Мази', 4, '2.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `level3`
--

CREATE TABLE IF NOT EXISTS `level3` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `id_apteka` int(11) NOT NULL,
  `id_class` int(11) NOT NULL,
  `pic` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `level3`
--

INSERT INTO `level3` (`id`, `name`, `id_apteka`, `id_class`, `pic`) VALUES
(1, 'альфак', 1, 3, 'альфак.jpg'),
(2, 'Гепариновая мазь', 1, 2, 'Гепариновая мазь.jpg'),
(3, 'Тилорам', 1, 1, '232587.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `familiya` varchar(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `admin` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `name`, `familiya`, `login`, `pass`, `admin`) VALUES
(1, 'Сергей', 'Поврозюк', 'povser', '123', 1),
(2, 'Вася', 'Петров', 'vas', '123', 0),
(3, 'Петя', 'Васин', 'petr', '123', 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
