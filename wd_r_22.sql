-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 21, 2021 at 09:04 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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

CREATE TABLE `addlecture` (
  `LecName` varchar(100) NOT NULL,
  `EmpID` int(6) NOT NULL,
  `Faculty` varchar(50) NOT NULL,
  `Department` varchar(50) NOT NULL,
  `Center` varchar(30) NOT NULL,
  `Building` varchar(30) NOT NULL,
  `Level` varchar(30) NOT NULL,
  `Rank` int(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addlecture`
--

INSERT INTO `addlecture` (`LecName`, `EmpID`, `Faculty`, `Department`, `Center`, `Building`, `Level`, `Rank`) VALUES
('Jude Dilshan', 5, 'Computing', 'Software engneering', ' Malabe', 'Computing', 'Senior Lecturer(HG)', 3),
('Tharindu Liyanage', 4, 'Computing', 'Software engneering', ' Malabe', 'Computing', 'Senior Lecturer(HG)', 3),
('Pasindu Amarasinghe', 3, 'Computing', 'Software engneering', ' Malabe', 'Computing', 'Professor', 1),
('Laksala Malkanthi', 2, 'Computing', 'Software engneering', ' Malabe', 'Computing', 'Professor', 1),
('Kavindu Kalhara', 1, 'Computing', 'Software engneering', ' Malabe', 'Computing', 'Assistant Professor', 2),
('Disal Peelapitiya', 6, 'Computing', 'Software engneering', ' Malabe', 'Computing', 'Professor', 1);

-- --------------------------------------------------------

--
-- Table structure for table `addlocation`
--

CREATE TABLE `addlocation` (
  `buildingName` varchar(255) NOT NULL,
  `roomName` varchar(255) NOT NULL,
  `roomType` varchar(30) NOT NULL,
  `capacity` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addlocation`
--

INSERT INTO `addlocation` (`buildingName`, `roomName`, `roomType`, `capacity`) VALUES
('Computing Building', 'C501', 'Lecture Hall', 100),
('Computing Building', 'C502', 'Lecture Hall', 200),
('Computing Building', 'C503', 'Laboratory', 200),
('Computing Building', 'C504', 'Lecture Hall', 200),
('New Building', 'N301', 'Laboratory', 200),
('New Building', 'N302', 'Lecture Hall', 300);

-- --------------------------------------------------------

--
-- Table structure for table `addsesstion`
--

CREATE TABLE `addsesstion` (
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
('Computing', 'Software engneering', 'Jude Dilshan', 'Jude Dilshan', 'DS1010', 'Tutorial', 'Y1 S1.SE.01', 'DS', 100, 'Monday', 'C503', '8.30 to 10.30', 'Jude Dilshan,Jude Dilshan,Y1 S1.SE.01,DS,DS1010,Tutorial,100'),
('Computing', 'Software engneering', 'Tharindu Liyanage', 'Tharindu Liyanage', 'IP1011', 'Lecture', 'Y1 S2.SE.02', 'IP', 100, 'Tuesday', 'NULL', '8.30 to 10.30', 'Tharindu Liyanage,Tharindu Liyanage,Y1 S2.SE.02,IP,IP1011,Lecture,100'),
('Computing', 'Software engneering', 'Pasindu Amarasinghe', 'Pasindu Amarasinghe', 'ITP123', 'Lecture', 'Y2 S1.SE.03', 'ITP', 100, 'Friday', 'C501', '8.30 to 10.30', 'Pasindu Amarasinghe,Pasindu Amarasinghe,Y2 S1.SE.03,ITP,ITP123,Lecture,100'),
('Computing', 'Software engneering', 'Pasindu Amarasinghe', 'Pasindu Amarasinghe', 'ITP123', 'Lecture', 'Y1 S1.SE.01', 'ITP', 100, 'Tuesday', 'C502', '10.30 to 12.30', 'Pasindu Amarasinghe,Pasindu Amarasinghe,Y1 S1.SE.01,ITP,ITP123,Lecture,100'),
('Computing', 'Software engneering', 'Laksala Malkanthi', 'Laksala Malkanthi', 'ITP123', 'Lecture', 'Y1 S1.SE.01', 'ITP', 100, 'Wednesday', 'NULL', '10.30 to 12.30', 'Laksala Malkanthi,Laksala Malkanthi,Y1 S1.SE.01,ITP,ITP123,Lecture,100'),
('Computing', 'Software engneering', 'Kavindu Kalhara', 'Disal Peelapitiya', 'OOP210', 'Lab', 'Y1 S1.SE.01', 'OOP', 100, 'Wednesday', 'C503', '1.30 to 3.30', 'Kavindu Kalhara,Disal Peelapitiya,Y1 S1.SE.01,OOP,OOP210,Lab,100'),
('Computing', 'Software engneering', 'Disal Peelapitiya', 'Disal Peelapitiya', 'IP1011', 'Lecture', 'Y1 S1.SE.01', 'IP', 100, 'Wednesday', 'C502', '3.30 to 5.30', 'Disal Peelapitiya,Disal Peelapitiya,Y1 S1.SE.01,IP,IP1011,Lecture,100'),
('Computing', 'Software engneering', 'Pasindu Amarasinghe', 'Pasindu Amarasinghe', 'ITP123', 'Lecture', 'Y1 S1.SE.01', 'ITP', 100, 'Friday', 'C503', '3.30 to 5.30', 'Pasindu Amarasinghe,Pasindu Amarasinghe,Y1 S1.SE.01,ITP,ITP123,Lecture,100'),
('Computing', 'Software engneering', 'Pasindu Amarasinghe', 'Pasindu Amarasinghe', 'ITP123', 'Lecture', 'Y1 S2.SE.02', 'ITP', 100, 'Friday', 'C503', '3.30 to 5.30', 'Pasindu Amarasinghe,Pasindu Amarasinghe,Y1 S2.SE.02,ITP,ITP123,Lecture,100'),
('Computing', 'Software engneering', 'Pasindu Amarasinghe', 'Pasindu Amarasinghe', 'OOP210', 'Lab', 'Y1 S2.SE.02', 'OOP', 100, 'Monday', 'C502', '10.30 to 12.30', 'Pasindu Amarasinghe,Pasindu Amarasinghe,Y1 S2.SE.02,OOP,OOP210,Lab,100'),
('Computing', 'Software engneering', 'Jude Dilshan', 'Jude Dilshan', 'IP1011', 'Lecture', 'Y1 S2.SE.02', 'IP', 100, 'Monday', 'C503', '3.30 to 5.30', 'Jude Dilshan,Jude Dilshan,Y1 S2.SE.02,IP,IP1011,Lecture,100'),
('Computing', 'Software engneering', 'Kavindu Kalhara', 'Kavindu Kalhara', 'MAD', 'Lab', 'Y1 S2.SE.02', 'MAD', 100, 'Thursday', 'C503', '8.30 to 10.30', 'Kavindu Kalhara,Kavindu Kalhara,Y1 S2.SE.02,MAD,MAD,Lab,100');

-- --------------------------------------------------------

--
-- Table structure for table `addstudentgrp`
--

CREATE TABLE `addstudentgrp` (
  `Fac` varchar(40) NOT NULL,
  `Dep` varchar(100) NOT NULL,
  `AcademicSemYear` varchar(20) NOT NULL,
  `Programme` varchar(40) NOT NULL,
  `GrpNo` varchar(20) NOT NULL,
  `SubGrpNum` varchar(20) NOT NULL,
  `GrpID` varchar(20) NOT NULL,
  `SubGrpID` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addstudentgrp`
--

INSERT INTO `addstudentgrp` (`Fac`, `Dep`, `AcademicSemYear`, `Programme`, `GrpNo`, `SubGrpNum`, `GrpID`, `SubGrpID`) VALUES
('Computing', 'Software engneering', 'Y3 S2', 'SE', '06', 'S2', 'Y3 S2.SE.06', 'Y3 S2.SE.06.S2'),
('Computing', 'Software engneering', 'Y3 S1', 'SE', '05', 'S1', 'Y3 S1.SE.05', 'Y3 S1.SE.05.S1'),
('Computing', 'Software engneering', 'Y2 S2', 'SE', '04', 'S2', 'Y2 S2.SE.04', 'Y2 S2.SE.04.S2'),
('Computing', 'Software engneering', 'Y2 S1', 'SE', '03', 'S1', 'Y2 S1.SE.03', 'Y2 S1.SE.03.S1'),
('Computing', 'Software engneering', 'Y1 S2', 'SE', '02', 'S2', 'Y1 S2.SE.02', 'Y1 S2.SE.02.S2'),
('Computing', 'Software engneering', 'Y1 S1', 'SE', '01', 'S1', 'Y1 S1.SE.01', 'Y1 S1.SE.01.S1');

-- --------------------------------------------------------

--
-- Table structure for table `addsubject`
--

CREATE TABLE `addsubject` (
  `department` varchar(100) NOT NULL,
  `dep2` varchar(50) NOT NULL,
  `OfferdYear` varchar(20) NOT NULL,
  `OfferedSem` varchar(20) NOT NULL,
  `SubjectName` varchar(20) NOT NULL,
  `SubjectCode` varchar(15) NOT NULL,
  `NoOfLecHours` int(2) NOT NULL,
  `NoOfTuHours` int(2) NOT NULL,
  `NoOfLabHours` int(2) NOT NULL,
  `NoOfEveHours` int(2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addsubject`
--

INSERT INTO `addsubject` (`department`, `dep2`, `OfferdYear`, `OfferedSem`, `SubjectName`, `SubjectCode`, `NoOfLecHours`, `NoOfTuHours`, `NoOfLabHours`, `NoOfEveHours`) VALUES
('Software engneering', 'Information systems', 'Y2', '2nd Semester', 'ITP', 'ITP123', 2, 1, 1, 1),
('Software engneering', '', 'Y2', '1st Semester', 'OOP', 'OOP210', 3, 2, 2, 2),
('Software engneering', 'Computer Sciance', 'Y1', '2nd Semester', 'IWT', 'IWT110', 2, 1, 1, 1),
('Software engneering', 'Business studies and software engneering', 'Y1', '1st Semester', 'IP', 'IP1011', 2, 1, 1, 1),
('Software engneering', 'Information systems', 'Y3', '1st Semester', 'DS', 'DS1010', 3, 2, 2, 2),
('Software engneering', 'Computer Sciance', 'Y3', '2nd Semester', 'MAD', 'MAD', 4, 2, 2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `addtag`
--

CREATE TABLE `addtag` (
  `SubjectTagName` varchar(40) NOT NULL,
  `SubjectTagCode` varchar(6) NOT NULL,
  `RelatedTag` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addtag`
--

INSERT INTO `addtag` (`SubjectTagName`, `SubjectTagCode`, `RelatedTag`) VALUES
('IWT', 'IWT110', 'Tutorial'),
('OOP', 'OOP210', 'Lab'),
('ITP', 'ITP123', 'Lecture'),
('IP', 'IP1011', 'Lecture'),
('DS', 'DS1010', 'Tutorial'),
('MAD', 'MAD', 'Lab');

-- --------------------------------------------------------

--
-- Table structure for table `addtime`
--

CREATE TABLE `addtime` (
  `timeID` int(10) NOT NULL,
  `StartTime` int(7) NOT NULL,
  `TimeSlot` int(15) NOT NULL,
  `EndTime` int(7) NOT NULL,
  `allTimes` varchar(40) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addtime`
--

INSERT INTO `addtime` (`timeID`, `StartTime`, `TimeSlot`, `EndTime`, `allTimes`) VALUES
(3, 1, 2, 3, '1.30 to 3.30'),
(2, 10, 2, 12, '10.30 to 12.30'),
(1, 8, 2, 10, '8.30 to 10.30'),
(4, 3, 2, 5, '3.30 to 5.30');

-- --------------------------------------------------------

--
-- Table structure for table `nottimeavailable`
--

CREATE TABLE `nottimeavailable` (
  `firstLec` varchar(50) NOT NULL,
  `grp` varchar(30) NOT NULL,
  `subject` varchar(100) NOT NULL,
  `tag` varchar(40) NOT NULL,
  `day` varchar(40) NOT NULL,
  `noOfStd` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `nottimeavailable`
--

INSERT INTO `nottimeavailable` (`firstLec`, `grp`, `subject`, `tag`, `day`, `noOfStd`) VALUES
('Saman Ramanayake', 'Y1 S1.SE.01', 'PS', 'PS', 'Monday', 100),
('Jude Dilshan', 'Y1 S1.SE.01', 'ITP', 'ITP', 'Monday', 100),
('Tharindu Liyanage', 'Y1 S2.SE.02', 'OOP', 'OOP', 'Tuesday', 100),
('Pasindu Amarasinghe', 'Y1 S2.SE.02', 'IWT', 'IWT', 'Wednesday', 100),
('Laksala Malkanthi', 'Y2 S1.SE.03', 'IP', 'IP', 'Thursday', 100),
('Kavindu Kalhara', 'Y2 S2.SE.04', 'DS', 'DS', 'Friday', 100),
('Disal Peelapitiya', 'Y3 S1.SE.05', 'MAD', 'MAD', 'Sunday', 100);

-- --------------------------------------------------------

--
-- Table structure for table `workingdays`
--

CREATE TABLE `workingdays` (
  `EmpID` int(6) NOT NULL,
  `NoOfWorkingDays` int(1) NOT NULL,
  `Monday` varchar(6) NOT NULL,
  `Tuesday` varchar(7) NOT NULL,
  `Wednesday` varchar(9) NOT NULL,
  `Thursday` varchar(8) NOT NULL,
  `Friday` varchar(6) NOT NULL,
  `Saturday` varchar(8) NOT NULL,
  `Sunday` varchar(6) NOT NULL,
  `WrkTimePerDay` time(6) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `workingdays`
--

INSERT INTO `workingdays` (`EmpID`, `NoOfWorkingDays`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`, `WrkTimePerDay`) VALUES
(5, 5, 'monday', 'tuesday', 'wednesday', '', 'friday', '', 'sunday', '04:00:00.000000'),
(4, 5, 'monday', 'tuesday', '', '', 'friday', 'saturday', 'sunday', '04:00:00.000000'),
(3, 4, 'monday', 'tuesday', 'wednesday', '', 'friday', '', '', '04:00:00.000000'),
(2, 4, 'monday', 'tuesday', '', 'thursday', 'friday', '', '', '04:00:00.000000'),
(1, 5, 'monday', 'tuesday', 'wednesday', 'thursday', 'friday', '', '', '04:00:00.000000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addlecture`
--
ALTER TABLE `addlecture`
  ADD PRIMARY KEY (`EmpID`);

--
-- Indexes for table `addlocation`
--
ALTER TABLE `addlocation`
  ADD PRIMARY KEY (`roomName`);

--
-- Indexes for table `addstudentgrp`
--
ALTER TABLE `addstudentgrp`
  ADD PRIMARY KEY (`GrpID`);

--
-- Indexes for table `addsubject`
--
ALTER TABLE `addsubject`
  ADD PRIMARY KEY (`SubjectCode`);

--
-- Indexes for table `addtag`
--
ALTER TABLE `addtag`
  ADD PRIMARY KEY (`SubjectTagCode`);

--
-- Indexes for table `addtime`
--
ALTER TABLE `addtime`
  ADD PRIMARY KEY (`timeID`);

--
-- Indexes for table `workingdays`
--
ALTER TABLE `workingdays`
  ADD PRIMARY KEY (`EmpID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
