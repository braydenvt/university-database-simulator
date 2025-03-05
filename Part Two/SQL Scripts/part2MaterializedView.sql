USE [391Project2]

DROP VIEW IF EXISTS dbo.EnrollmentSummary
DROP PROC IF EXISTS extractData
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

---------------------------------------------------------------------------------------------------

CREATE PROC extractData
    @CountType VARCHAR(20),
    @CountBy VARCHAR(10),
    @CourseId INT = NULL,
    @InstructorId INT = NULL,
    @StudentId INT = NULL,
    @DateId INT = NULL,
    @Grade VARCHAR(2) = NULL,
    @Department VARCHAR(50) = NULL,
    @CourseFaculty VARCHAR(50) = NULL,
    @CourseUniversity VARCHAR(50) = NULL,
    @InstructorFaculty VARCHAR(50) = NULL,
    @InstructorRank VARCHAR(50) = NULL,
    @InstructorUniversity VARCHAR(50) = NULL,
    @Major VARCHAR(50) = NULL,
    @Gender VARCHAR(10) = NULL,
    @Semester VARCHAR(20) = NULL,
    @Year INT = NULL
AS
BEGIN
    SELECT 
        CASE 
            WHEN @CountType = 'Distinct' THEN 
                CASE @CountBy
                    WHEN 'Enrollment' THEN COUNT(DISTINCT CONCAT(InstructorId, '-', StudentId, '-', DateId, '-', CourseId))
                    WHEN 'Instructor' THEN COUNT(DISTINCT InstructorId)
                    WHEN 'Student' THEN COUNT(DISTINCT StudentId)
                    WHEN 'Date' THEN COUNT(DISTINCT DateId)
                    WHEN 'Course' THEN COUNT(DISTINCT CourseId)
                    ELSE 0
                END
            ELSE 
                CASE @CountBy
                    WHEN 'Enrollment' THEN COUNT(CONCAT(InstructorId, '-', StudentId, '-', DateId, '-', CourseId))
                    WHEN 'Instructor' THEN COUNT(InstructorId)
                    WHEN 'Student' THEN COUNT(StudentId)
                    WHEN 'Date' THEN COUNT(DateId)
                    WHEN 'Course' THEN COUNT(CourseId)
                    ELSE 0
                END
        END AS Occurrences
    FROM [391Project2].[dbo].[EnrollmentSummary]
    WHERE (@CourseId IS NULL OR CourseId = @CourseId) 
      AND (@InstructorId IS NULL OR InstructorId = @InstructorId)
      AND (@StudentId IS NULL OR StudentId = @StudentId) 
      AND (@DateId IS NULL OR DateId = @DateId) 
      AND (@Grade IS NULL OR Grade = @Grade) 
      AND (@Department IS NULL OR Department = @Department) 
      AND (@CourseFaculty IS NULL OR CourseFaculty = @CourseFaculty) 
      AND (@CourseUniversity IS NULL OR CourseUniversity = @CourseUniversity)
      AND (@InstructorFaculty IS NULL OR InstructorFaculty = @InstructorFaculty) 
      AND (@InstructorRank IS NULL OR InstructorRank = @InstructorRank)
      AND (@InstructorUniversity IS NULL OR InstructorUniversity = @InstructorUniversity) 
      AND (@Major IS NULL OR Major = @Major) 
      AND (@Gender IS NULL OR Gender = @Gender) 
      AND (@Semester IS NULL OR Semester = @Semester) 
      AND (@Year IS NULL OR [Year] = @Year)
END