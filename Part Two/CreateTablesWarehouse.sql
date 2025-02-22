USE [391Project2];

-- Drop tables if they already exist
DROP TABLE IF EXISTS Enrollment;
DROP TABLE IF EXISTS Course;
DROP TABLE IF EXISTS Instructor;
DROP TABLE IF EXISTS Student;
DROP TABLE IF EXISTS Date;

-- Create Course table
CREATE TABLE Course (
    CourseId INT PRIMARY KEY,
    Department VARCHAR(20),
    Faculty VARCHAR(20),
    University VARCHAR(30)
);

-- Create Instructor table
CREATE TABLE Instructor (
    InstructorId INT PRIMARY KEY,
    Faculty VARCHAR(20),
    Rank VARCHAR(20),
    University VARCHAR(30)
);

-- Create Student table
CREATE TABLE Student (
    StudentId INT PRIMARY KEY,
    Major VARCHAR(20),
    Gender VARCHAR(20)
);

-- Create Date table
CREATE TABLE Date (
    DateId INT IDENTITY(1,1) PRIMARY KEY,
    Semester VARCHAR(20),
    Year INT,
);

-- Create Enrollment table (Fact Table)
CREATE TABLE Enrollment (
    CourseId INT NOT NULL,
    InstructorId INT NOT NULL,
    StudentId INT NOT NULL,
    DateId INT NOT NULL,

    -- Define Primary Key (Composite Key)
    PRIMARY KEY (CourseId, InstructorId, StudentId, DateId),

    -- Define Foreign Keys
    FOREIGN KEY (CourseId) REFERENCES Course(CourseId) ON DELETE CASCADE,
    FOREIGN KEY (InstructorId) REFERENCES Instructor(InstructorId) ON DELETE CASCADE,
    FOREIGN KEY (StudentId) REFERENCES Student(StudentId) ON DELETE CASCADE,
    FOREIGN KEY (DateId) REFERENCES Date(DateId) ON DELETE CASCADE
);