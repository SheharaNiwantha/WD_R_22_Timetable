-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 18, 2021 at 06:33 PM
-- Server version: 5.7.26
-- PHP Version: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wd_r_22`
--

-- --------------------------------------------------------

--
-- Table structure for table `addlecture`
--

DROP TABLE IF EXISTS `addlecture`;
CREATE TABLE IF NOT EXISTS `addlecture` (
  `LecName` varchar(100) NOT NULL,
  `EmpID` int(6) NOT NULL,
  `Faculty` varchar(50) NOT NULL,
  `Department` varchar(50) NOT NULL,
  `Center` varchar(30) NOT NULL,
  `Building` varchar(30) NOT NULL,
  `Level` varchar(30) NOT NULL,
  `Rank` int(20) NOT NULL,
  PRIMARY KEY (`EmpID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addlecture`
--

INSERT INTO `addlecture` (`LecName`, `EmpID`, `Faculty`, `Department`, `Center`, `Building`, `Level`, `Rank`) VALUES
('Ravindu lakshan', 1, 'Computing', 'Software engneering', 'Kurunagala', 'Computing', 'Professor', 1),
('Rangana Atapattu', 2, 'Computing', 'Software engneering', 'Kurunagala', 'Computing', 'Professor', 1),
('Madawa Balasooriya', 3, 'Computing', 'Software engneering', 'Kurunagala', 'Computing', 'Professor', 1),
('Chathuranga Premathilaka', 4, 'Computing', 'Software engneering', 'Kurunagala', 'Computing', 'Assistant Professor', 2),
('Sangeetha Gamage', 5, 'Computing', 'Information systems', 'Kurunagala', 'Computing', 'Assistant Professor', 2),
('Shan Ratnayake', 6, 'Computing', 'Information systems', 'Kurunagala', 'Computing', 'Senior Lecturer(HG)', 3),
('Nawodya Senaratne', 7, 'Computing', 'Information systems', 'Kurunagala', 'Computing', 'Senior Lecturer(HG)', 3),
('Vidura Ekanayake', 8, 'Computing', 'Software engneering', 'Kurunagala', 'Computing', 'Assistant Professor', 2),
('Chamath ', 9, 'Computing', 'Software engneering', 'Kurunagala', 'Computing', 'Professor', 1);

-- --------------------------------------------------------

--
-- Table structure for table `addlocation`
--

DROP TABLE IF EXISTS `addlocation`;
CREATE TABLE IF NOT EXISTS `addlocation` (
  `buildingName` varchar(255) NOT NULL,
  `roomName` varchar(255) NOT NULL,
  `roomType` varchar(30) NOT NULL,
  `capacity` int(10) NOT NULL,
  PRIMARY KEY (`roomName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addlocation`
--

INSERT INTO `addlocation` (`buildingName`, `roomName`, `roomType`, `capacity`) VALUES
('Computing Building', 'A301', 'Lecture Hall', 100),
('Computing Building', 'A302', 'Lecture Hall', 100),
('Computing Building', 'A303', '', 100),
('Computing Building', 'A304', '', 100),
('Computing Building', 'A305', '', 100),
('Computing Building', 'A306', '', 100),
('Computing Building', 'B501', 'Lecture Hall', 100);

-- --------------------------------------------------------

--
-- Table structure for table `addsesstion`
--

DROP TABLE IF EXISTS `addsesstion`;
CREATE TABLE IF NOT EXISTS `addsesstion` (
  `Fac` varchar(20) NOT NULL,
  `department` varchar(40) NOT NULL,
  `firstLec` varchar(50) NOT NULL,
  `secondLec` varchar(50) NOT NULL,
  `tag` varchar(50) NOT NULL,
  `tagType` varchar(15) NOT NULL,
  `grp` varchar(40) NOT NULL,
  `subject` varchar(100) NOT NULL,
  `noOfStd` int(4) NOT NULL,
  `day` varchar(15) NOT NULL,
  `room` varchar(10) NOT NULL,
  `time` varchar(50) NOT NULL,
  `AllDetails` varchar(400) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addsesstion`
--

INSERT INTO `addsesstion` (`Fac`, `department`, `firstLec`, `secondLec`, `tag`, `tagType`, `grp`, `subject`, `noOfStd`, `day`, `room`, `time`, `AllDetails`) VALUES
('Computing', 'Software engneering', 'Ravindu lakshan', 'Ravindu lakshan', 'IT4100', 'Lecture', 'Y4 S1.SE.05', 'CTSE', 50, 'Monday', 'A301', '8.30 to 12.30', 'Ravindu lakshan,Ravindu lakshan,Y4 S1.SE.05,CTSE,IT4100,Lecture,50'),
('Computing', 'Software engneering', 'Ravindu lakshan', 'Ravindu lakshan', 'IT4100', 'Lecture', 'Y4 S1.SE.05', 'CTSE', 50, 'Monday', 'A301', '13.30 to 17.30', 'Ravindu lakshan,Ravindu lakshan,Y4 S1.SE.05,CTSE,IT4100,Lecture,50');

-- --------------------------------------------------------

--
-- Table structure for table `addstudentgrp`
--

DROP TABLE IF EXISTS `addstudentgrp`;
CREATE TABLE IF NOT EXISTS `addstudentgrp` (
  `Fac` varchar(40) NOT NULL,
  `Dep` varchar(100) NOT NULL,
  `AcademicSemYear` varchar(20) NOT NULL,
  `Programme` varchar(40) NOT NULL,
  `GrpNo` varchar(20) NOT NULL,
  `SubGrpNum` varchar(20) NOT NULL,
  `GrpID` varchar(20) NOT NULL,
  `SubGrpID` varchar(20) NOT NULL,
  PRIMARY KEY (`GrpID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addstudentgrp`
--

INSERT INTO `addstudentgrp` (`Fac`, `Dep`, `AcademicSemYear`, `Programme`, `GrpNo`, `SubGrpNum`, `GrpID`, `SubGrpID`) VALUES
('', '', 'Y1 S2', 'SE', '02', 'S2', 'Y1 S2.SE.02', 'Y1 S2.SE.02.S2'),
('', '', 'Y4 S1', 'SE', '02', 'S1', 'Y4 S1.SE.02', 'Y4 S1.SE.02.S1'),
('', '', 'Y4 S1', 'SE', '03', 'S1', 'Y4 S1.SE.03', 'Y4 S1.SE.03.S1'),
('', '', 'Y4 S1', 'SE', '04', 'S1', 'Y4 S1.SE.04', 'Y4 S1.SE.04.S1'),
('', '', 'Y4 S1', 'SE', '05', 'S1', 'Y4 S1.SE.05', 'Y4 S1.SE.05.S1'),
('Computing', 'Software engneering', 'Y4 S1', 'SE', '07', 'S2', 'Y4 S1.SE.07', 'Y4 S1.SE.07.S2');

-- --------------------------------------------------------

--
-- Table structure for table `addsubject`
--

DROP TABLE IF EXISTS `addsubject`;
CREATE TABLE IF NOT EXISTS `addsubject` (
  `department` varchar(100) NOT NULL,
  `dep2` varchar(50) NOT NULL,
  `OfferdYear` varchar(20) NOT NULL,
  `OfferedSem` varchar(20) NOT NULL,
  `SubjectName` varchar(20) NOT NULL,
  `SubjectCode` varchar(15) NOT NULL,
  `NoOfLecHours` int(2) NOT NULL,
  `NoOfTuHours` int(2) NOT NULL,
  `NoOfLabHours` int(2) NOT NULL,
  `NoOfEveHours` int(2) NOT NULL,
  PRIMARY KEY (`SubjectCode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addsubject`
--

INSERT INTO `addsubject` (`department`, `dep2`, `OfferdYear`, `OfferedSem`, `SubjectName`, `SubjectCode`, `NoOfLecHours`, `NoOfTuHours`, `NoOfLabHours`, `NoOfEveHours`) VALUES
('Software engneering', '', 'Y4', '1st Semester', 'CTSE', 'SE4010', 8, 0, 0, 0),
('Software engneering', '', 'Y4', '1st Semester', 'SSD', 'SE4030', 8, 0, 0, 0),
('Software engneering', '', 'Y4', '1st Semester', 'MADD', 'SE4020', 8, 0, 0, 0),
('Information systems', '', 'Y4', '1st Semester', 'SQA', 'IT4100', 8, 0, 0, 0),
('Information systems', '', 'Y4', '1st Semester', 'MTIT', 'IT4020', 8, 0, 0, 0),
('Information systems', '', 'Y4', '1st Semester', 'CC', 'IT4090', 8, 0, 0, 0),
('Software engneering', 'Information systems', 'Y4', '2nd Semester', 'PPW', 'IT4070', 8, 0, 0, 0),
('Software engneering', 'Information systems', 'Y4', '2nd Semester', 'ML', 'IT4060', 8, 0, 0, 0),
('Software engneering', 'Information systems', 'Y4', '2nd Semester', 'DA', 'IT4040', 8, 0, 0, 0),
('Software engneering', 'Information systems', 'Y4', '2nd Semester', 'Research Project', 'IT4010', 8, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `addtag`
--

DROP TABLE IF EXISTS `addtag`;
CREATE TABLE IF NOT EXISTS `addtag` (
  `SubjectTagName` varchar(40) NOT NULL,
  `SubjectTagCode` varchar(6) NOT NULL,
  `RelatedTag` varchar(20) NOT NULL,
  PRIMARY KEY (`SubjectTagCode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addtag`
--

INSERT INTO `addtag` (`SubjectTagName`, `SubjectTagCode`, `RelatedTag`) VALUES
('CTSE', 'SE4010', 'Lecture'),
('SSD', 'SE4030', 'Lecture'),
('MADD', 'SE4020', 'Lecture'),
('SQA', 'IT4100', 'Lecture');

-- --------------------------------------------------------

--
-- Table structure for table `addtime`
--

DROP TABLE IF EXISTS `addtime`;
CREATE TABLE IF NOT EXISTS `addtime` (
  `timeID` int(10) NOT NULL,
  `StartTime` int(7) NOT NULL,
  `TimeSlot` int(15) NOT NULL,
  `EndTime` int(7) NOT NULL,
  `allTimes` varchar(40) NOT NULL,
  PRIMARY KEY (`timeID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addtime`
--

INSERT INTO `addtime` (`timeID`, `StartTime`, `TimeSlot`, `EndTime`, `allTimes`) VALUES
(1, 8, 4, 12, '8.30 to 12.30'),
(2, 13, 4, 17, '13.30 to 17.30');

-- --------------------------------------------------------

--
-- Table structure for table `nottimeavailable`
--

DROP TABLE IF EXISTS `nottimeavailable`;
CREATE TABLE IF NOT EXISTS `nottimeavailable` (
  `firstLec` varchar(50) NOT NULL,
  `grp` varchar(30) NOT NULL,
  `subject` varchar(100) NOT NULL,
  `tag` varchar(40) NOT NULL,
  `day` varchar(40) NOT NULL,
  `noOfStd` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `workingdays`
--

DROP TABLE IF EXISTS `workingdays`;
CREATE TABLE IF NOT EXISTS `workingdays` (
  `EmpID` int(6) NOT NULL,
  `NoOfWorkingDays` int(1) NOT NULL,
  `Monday` varchar(6) NOT NULL,
  `Tuesday` varchar(7) NOT NULL,
  `Wednesday` varchar(9) NOT NULL,
  `Thursday` varchar(8) NOT NULL,
  `Friday` varchar(6) NOT NULL,
  `Saturday` varchar(8) NOT NULL,
  `Sunday` varchar(6) NOT NULL,
  `WrkTimePerDay` time(6) NOT NULL,
  PRIMARY KEY (`EmpID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `workingdays`
--

INSERT INTO `workingdays` (`EmpID`, `NoOfWorkingDays`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`, `WrkTimePerDay`) VALUES
(1, 4, 'monday', '', 'wednesday', 'thursday', 'friday', '', '', '08:00:00.000000'),
(2, 5, 'monday', '', 'wednesday', 'thursday', 'friday', 'saturday', '', '08:00:00.000000'),
(3, 3, 'monday', '', '', '', 'friday', 'saturday', '', '08:00:00.000000'),
(4, 6, 'monday', 'tuesday', 'wednesday', 'thursday', '', 'saturday', 'sunday', '07:00:00.000000'),
(5, 5, 'monday', 'tuesday', 'wednesday', 'thursday', '', 'saturday', '', '08:00:00.000000'),
(6, 3, '', 'tuesday', 'wednesday', 'thursday', '', '', '', '07:00:00.000000'),
(7, 4, '', 'tuesday', 'wednesday', 'thursday', '', 'saturday', '', '08:00:00.000000'),
(8, 3, 'monday', 'tuesday', '', 'thursday', '', '', '', '08:00:00.000000'),
(9, 4, 'monday', 'tuesday', '', 'thursday', 'friday', '', '', '08:00:00.000000');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
