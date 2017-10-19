-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2017 at 12:43 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_dost`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `adminID` int(11) NOT NULL,
  `adminUsername` char(50) NOT NULL,
  `adminPassword` char(50) NOT NULL,
  `adminLevel` int(1) NOT NULL,
  `lastBackup` varchar(30) NOT NULL,
  `lastRestore` varchar(30) NOT NULL,
  `emailAddress` varchar(254) DEFAULT NULL,
  `smtp` varchar(254) DEFAULT NULL,
  `smtpPort` int(10) DEFAULT NULL,
  `gmailSpecificPassword` varchar(30) DEFAULT NULL,
  `mailSubject` varchar(78) DEFAULT NULL,
  `mailMessagePasser` varchar(255) DEFAULT NULL,
  `mailMessageNonPasser` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`adminID`, `adminUsername`, `adminPassword`, `adminLevel`, `lastBackup`, `lastRestore`, `emailAddress`, `smtp`, `smtpPort`, `gmailSpecificPassword`, `mailSubject`, `mailMessagePasser`, `mailMessageNonPasser`) VALUES
(1, 'admin', 'Egg0DPiKuNIrrVmD8IUCuw1hQxNqZc=Bacon', 0, 'September 28, 2017 - 14:21', 'August 25, 2017 - 23:16', 'kunwaridost@gmail.com', 'smtp.gmail.com', 587, 'rebtebrwspnxkmex', 'DOST - PQE: Examinee Result', 'Thank you for applying, We appreciate your interest for joining the DOST family.', 'Thank you for attempting to apply, We appreciate your interest for joining the DOST family.\n'),
(7, 'admin1', 'admin1', 1, '', '', NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_examinee`
--

CREATE TABLE `tbl_examinee` (
  `examineeID` int(6) NOT NULL,
  `examineePic` mediumblob,
  `firstName` varchar(100) DEFAULT NULL,
  `lastName` varchar(100) DEFAULT NULL,
  `emailAddress` varchar(255) DEFAULT NULL,
  `dateTaken` varchar(50) DEFAULT NULL,
  `examineeDateID` varchar(50) DEFAULT NULL,
  `activeLevel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_examinee_score`
--

CREATE TABLE `tbl_examinee_score` (
  `examineeID` int(6) DEFAULT NULL,
  `kindID` int(6) DEFAULT NULL,
  `examineeScore` int(6) DEFAULT NULL,
  `setDescription` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_examinee_set`
--

CREATE TABLE `tbl_examinee_set` (
  `examineeID` int(11) DEFAULT NULL,
  `setDescription` varchar(1) NOT NULL,
  `result` varchar(20) DEFAULT NULL,
  `levelID` int(11) NOT NULL,
  `positionID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kind`
--

CREATE TABLE `tbl_kind` (
  `kindID` int(6) NOT NULL,
  `levelID` int(6) DEFAULT NULL,
  `testTypeID` int(6) DEFAULT NULL,
  `timer` varchar(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_kind`
--

INSERT INTO `tbl_kind` (`kindID`, `levelID`, `testTypeID`, `timer`) VALUES
(1, 1, 3, '70'),
(2, 1, 1, '60'),
(3, 1, 2, '60'),
(4, 2, 4, '10'),
(5, 2, 1, '10'),
(6, 2, 2, '30'),
(7, 3, 1, '10'),
(8, 3, 2, '10'),
(9, 3, 5, '10'),
(10, 3, 6, '101'),
(11, 3, 7, '10');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_level`
--

CREATE TABLE `tbl_level` (
  `levelID` int(6) NOT NULL,
  `levelDescription` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_level`
--

INSERT INTO `tbl_level` (`levelID`, `levelDescription`) VALUES
(1, 'Supervisory'),
(2, 'Non-Supervisory'),
(3, 'Clerical');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pending_emails`
--

CREATE TABLE `tbl_pending_emails` (
  `emailID` int(11) NOT NULL,
  `examineeID` int(11) NOT NULL,
  `result` varchar(10) NOT NULL,
  `pdfDocument` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_position`
--

CREATE TABLE `tbl_position` (
  `positionDescription` varchar(255) DEFAULT NULL,
  `positionID` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_position`
--

INSERT INTO `tbl_position` (`positionDescription`, `positionID`) VALUES
('Department Secretary', 1),
('Department Undersecretary', 2),
('Department Assistant Secretary', 3),
('Director IV', 4),
('Head Executive Assistant', 5),
('Associate Scientist', 6),
('Attorney V', 7),
('Assistant Scientist', 8),
('Chief Accountant', 9),
('Chief Administrative Officer', 10),
('Chief Science Research Specialist', 11),
('Internal Auditor V', 12),
('Planning Officer V', 13),
('Project Development Officer V', 14),
('Attorney IV', 15),
('Depertment Legislative Liaison Specialist', 16),
('Executive Assistant IV', 17),
('Internal Auditor IV', 18),
('International Science Relations Officer IV', 19),
('Planning Officer IV', 20),
('Project Development Officer IV', 21),
('Superivising Administrative Officer', 22),
('Superivising Science Research Specialist', 23),
('Engineer III', 24),
('Senior Science Research Specialist', 25),
('Administrative Officer V', 26),
('Internal Auditor III', 27),
('International Science Relations Officer III', 28),
('Planning Officer III', 29),
('Project Development Officer III', 30),
('Executive Assistant II', 31),
('Science Research Specialist II', 32),
('Administrative Officer II', 33),
('Information Officer II', 34),
('Internal Auditor II', 35),
('Planning Officer II', 36),
('Project Development Officer II', 37),
('Senior Administrative Assistant III', 38),
('Administrative Officer III', 39),
('Administrative Aide II', 40),
('Administrative Assistant V', 41),
('Administrative Officer I', 42),
('Motor Pool Supervisor II', 43),
('Administrative Assistant II', 44),
('Administrative Assistant I', 45),
('Administrative Aide VI', 46),
('Communications Equipment Operator II', 47),
('Administrative Aide IV', 48),
('Administrative Aide I', 49);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_question`
--

CREATE TABLE `tbl_question` (
  `questionID` int(6) NOT NULL,
  `kindID` int(6) DEFAULT NULL,
  `question` longblob,
  `choice1` varchar(255) DEFAULT NULL,
  `choice2` varchar(255) DEFAULT NULL,
  `choice3` varchar(255) DEFAULT NULL,
  `choice4` varchar(255) DEFAULT NULL,
  `correctAnswer` varchar(255) DEFAULT NULL,
  `setDescription` varchar(2) DEFAULT NULL,
  `questionNumber` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_response`
--

CREATE TABLE `tbl_response` (
  `examineeID` int(6) DEFAULT NULL,
  `questionID` int(6) DEFAULT NULL,
  `examineeAnswer` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_test_type`
--

CREATE TABLE `tbl_test_type` (
  `testTypeID` int(6) NOT NULL,
  `testTypeDescription` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_test_type`
--

INSERT INTO `tbl_test_type` (`testTypeID`, `testTypeDescription`) VALUES
(1, 'Numerical'),
(2, 'Verbal'),
(3, 'Management and Leadership Concept'),
(4, 'Reading Comprehension'),
(5, 'General Information and Current Events'),
(6, 'Clerical Reasoning'),
(7, 'Abstract Reasoning');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`adminID`);

--
-- Indexes for table `tbl_examinee`
--
ALTER TABLE `tbl_examinee`
  ADD PRIMARY KEY (`examineeID`);

--
-- Indexes for table `tbl_examinee_score`
--
ALTER TABLE `tbl_examinee_score`
  ADD KEY `kindID` (`kindID`),
  ADD KEY `examineeID` (`examineeID`);

--
-- Indexes for table `tbl_examinee_set`
--
ALTER TABLE `tbl_examinee_set`
  ADD KEY `examineeID` (`examineeID`),
  ADD KEY `levelID` (`levelID`),
  ADD KEY `positionID` (`positionID`);

--
-- Indexes for table `tbl_kind`
--
ALTER TABLE `tbl_kind`
  ADD PRIMARY KEY (`kindID`),
  ADD KEY `levelID` (`levelID`),
  ADD KEY `testTypeID` (`testTypeID`);

--
-- Indexes for table `tbl_level`
--
ALTER TABLE `tbl_level`
  ADD PRIMARY KEY (`levelID`);

--
-- Indexes for table `tbl_pending_emails`
--
ALTER TABLE `tbl_pending_emails`
  ADD PRIMARY KEY (`emailID`),
  ADD KEY `examineeID` (`examineeID`);

--
-- Indexes for table `tbl_position`
--
ALTER TABLE `tbl_position`
  ADD PRIMARY KEY (`positionID`);

--
-- Indexes for table `tbl_question`
--
ALTER TABLE `tbl_question`
  ADD PRIMARY KEY (`questionID`);

--
-- Indexes for table `tbl_response`
--
ALTER TABLE `tbl_response`
  ADD KEY `examineeID` (`examineeID`),
  ADD KEY `questionID` (`questionID`);

--
-- Indexes for table `tbl_test_type`
--
ALTER TABLE `tbl_test_type`
  ADD PRIMARY KEY (`testTypeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `adminID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tbl_examinee`
--
ALTER TABLE `tbl_examinee`
  MODIFY `examineeID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;
--
-- AUTO_INCREMENT for table `tbl_kind`
--
ALTER TABLE `tbl_kind`
  MODIFY `kindID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tbl_level`
--
ALTER TABLE `tbl_level`
  MODIFY `levelID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_pending_emails`
--
ALTER TABLE `tbl_pending_emails`
  MODIFY `emailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;
--
-- AUTO_INCREMENT for table `tbl_position`
--
ALTER TABLE `tbl_position`
  MODIFY `positionID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;
--
-- AUTO_INCREMENT for table `tbl_question`
--
ALTER TABLE `tbl_question`
  MODIFY `questionID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99;
--
-- AUTO_INCREMENT for table `tbl_test_type`
--
ALTER TABLE `tbl_test_type`
  MODIFY `testTypeID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_examinee_score`
--
ALTER TABLE `tbl_examinee_score`
  ADD CONSTRAINT `tbl_examinee_score_ibfk_1` FOREIGN KEY (`examineeID`) REFERENCES `tbl_examinee` (`examineeID`) ON DELETE CASCADE,
  ADD CONSTRAINT `tbl_examinee_score_ibfk_2` FOREIGN KEY (`kindID`) REFERENCES `tbl_kind` (`kindID`);

--
-- Constraints for table `tbl_examinee_set`
--
ALTER TABLE `tbl_examinee_set`
  ADD CONSTRAINT `tbl_examinee_set_ibfk_1` FOREIGN KEY (`examineeID`) REFERENCES `tbl_examinee` (`examineeID`),
  ADD CONSTRAINT `tbl_examinee_set_ibfk_2` FOREIGN KEY (`positionID`) REFERENCES `tbl_position` (`positionID`),
  ADD CONSTRAINT `tbl_examinee_set_ibfk_3` FOREIGN KEY (`levelID`) REFERENCES `tbl_level` (`levelID`);

--
-- Constraints for table `tbl_kind`
--
ALTER TABLE `tbl_kind`
  ADD CONSTRAINT `tbl_kind_ibfk_1` FOREIGN KEY (`testTypeID`) REFERENCES `tbl_test_type` (`testTypeID`),
  ADD CONSTRAINT `tbl_kind_ibfk_2` FOREIGN KEY (`levelID`) REFERENCES `tbl_level` (`levelID`);

--
-- Constraints for table `tbl_pending_emails`
--
ALTER TABLE `tbl_pending_emails`
  ADD CONSTRAINT `tbl_pending_emails_ibfk_1` FOREIGN KEY (`examineeID`) REFERENCES `tbl_examinee` (`examineeID`);

--
-- Constraints for table `tbl_response`
--
ALTER TABLE `tbl_response`
  ADD CONSTRAINT `tbl_response_ibfk_1` FOREIGN KEY (`examineeID`) REFERENCES `tbl_examinee` (`examineeID`),
  ADD CONSTRAINT `tbl_response_ibfk_2` FOREIGN KEY (`questionID`) REFERENCES `tbl_question` (`questionID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
# Privileges for `client`@`%`

GRANT SELECT, INSERT, UPDATE ON *.* TO 'client'@'%' IDENTIFIED BY PASSWORD '*DA9C7CC64656F1C45DD8257686F9E2C5C9C0C367';


# Privileges for `client`@`localhost`

GRANT SELECT, INSERT, UPDATE ON *.* TO 'client'@'localhost' IDENTIFIED BY PASSWORD '*DA9C7CC64656F1C45DD8257686F9E2C5C9C0C367';


# Privileges for `root`@`localhost`

GRANT ALL PRIVILEGES ON *.* TO 'root'@'localhost' WITH GRANT OPTION;

GRANT PROXY ON ''@'%' TO 'root'@'localhost' WITH GRANT OPTION;