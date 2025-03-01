USE [391Project2]

DROP VIEW IF EXISTS dbo.EnrollmentSummary
GO

CREATE VIEW dbo.EnrollmentSummary
WITH SCHEMABINDING
AS
SELECT 
    E.CourseId, 
    E.InstructorId, 
    E.StudentId, 
    E.DateId, 
    E.Grade, 
    C.Department, 
    C.Faculty AS CourseFaculty, 
    C.University AS CourseUniversity, 
    I.Faculty AS InstructorFaculty, 
    I.Rank AS InstructorRank, 
    I.University AS InstructorUniversity, 
    S.Major, 
    S.Gender, 
    D.Semester, 
    D.Year
FROM dbo.Enrollment E
INNER JOIN dbo.Course C ON E.CourseId = C.CourseId
INNER JOIN dbo.Instructor I ON E.InstructorId = I.InstructorId
INNER JOIN dbo.Student S ON E.StudentId = S.StudentId
INNER JOIN dbo.Date D ON E.DateId = D.DateId;
GO

CREATE UNIQUE CLUSTERED INDEX IDX_V1 ON dbo.EnrollmentSummary (CourseId, InstructorId, StudentId, DateId);
GO