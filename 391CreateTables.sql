USE [391Project]

drop view if exists ActiveEnrollment
drop view if exists CourseOfferings
drop procedure if exists checkPrereq
drop procedure if exists checkTimeConflict
drop procedure if exists IsSectionOpen
drop procedure if exists FillSearch
drop procedure if exists EnrolFromCart

DROP TABLE IF EXISTS Cart;
DROP TABLE IF EXISTS Enrollment;
DROP TABLE IF EXISTS Section;
DROP TABLE IF EXISTS Student;
DROP TABLE IF EXISTS Prereq;
DROP TABLE IF EXISTS Instructor;
DROP TABLE IF EXISTS Course;
DROP TABLE IF EXISTS Department;


CREATE TABLE Student (
SID INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
Active VARCHAR(1),
CONSTRAINT chk_Active CHECK (Active IN ('Y', 'N'))
);
 
CREATE TABLE Department (
DID VARCHAR(4) PRIMARY KEY,
DeptName VARCHAR(50),
Location VARCHAR(50)
);

CREATE TABLE Course (
--CID INT IDENTITY(1,1) PRIMARY KEY,
CID VARCHAR(8) PRIMARY KEY,
Title VARCHAR(50),
DID VARCHAR(4),
FOREIGN KEY (DID) REFERENCES Department(DID)
);

CREATE TABLE Instructor (
IID INT IDENTITY(1,1)  PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
[Role] VARCHAR(50),
DID VARCHAR(4),
FOREIGN KEY (DID) REFERENCES Department(DID),
CONSTRAINT chk_Role CHECK (Role IN ('Head', 'Associate', 'Sessional'))
);

CREATE TABLE Section (
SecID INT IDENTITY(1,1)  PRIMARY KEY,
Semester VARCHAR(100),
MaxCapacity INT,
TimeBlock VARCHAR(2),
RoomNumber VARCHAR(5),
CID VARCHAR(8),
IID INT,
NumEnrolled INT,
FOREIGN KEY (CID) REFERENCES Course(CID),
FOREIGN KEY (IID) REFERENCES Instructor(IID)
);

CREATE TABLE Cart (
SID INT,
SecID INT,
PRIMARY KEY (SID, SecID),
FOREIGN KEY (SID) REFERENCES Student(SID),
FOREIGN KEY (SecID) REFERENCES Section(SecID)
);

CREATE TABLE Enrollment (
SID INT,
SecID INT,
PRIMARY KEY (SID, SecID),
FOREIGN KEY (SID) REFERENCES Student(SID),
FOREIGN KEY (SecID) REFERENCES Section(SecID)
);

CREATE TABLE Prereq (
CID VARCHAR(8),
PrereqID VARCHAR(8),
PRIMARY KEY (CID, PrereqID),
FOREIGN KEY (CID) REFERENCES Course(CID),
FOREIGN KEY (PrereqID) REFERENCES Course(CID)
);
