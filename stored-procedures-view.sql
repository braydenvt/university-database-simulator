USE [391Project]

GO
CREATE VIEW ActiveEnrollment
WITH SCHEMABINDING
AS 
-- Enrollment Table of only active students 
    SELECT E.SID, S.SecID, S.Semester, S.MaxCapacity, S.TimeBlock, S.CID, S.NumEnrolled
    FROM dbo.Enrollment AS E
    JOIN dbo.Student AS Stu ON E.SID = Stu.SID
    JOIN dbo.Section AS S ON E.SecID = S.SecID
    WHERE Stu.Active = 'Y'
GO

-- Create an index on the view.
CREATE UNIQUE CLUSTERED INDEX IDX_V1
   ON ActiveEnrollment(SID,SecID);

-------------------------------------------------
GO
CREATE PROC checkPrereq
    @SID INT,
    @CID INT,
    @Semester VARCHAR(15)
AS
BEGIN
    WITH Pr AS (
        SELECT PrereqID
        FROM Prereq
        WHERE CID = @CID
    ),
    Course AS (
        SELECT CID
        FROM ActiveEnrollment
        WHERE SID = @SID AND Semester != @Semester
    ),
    Intersection AS (
        SELECT *
        FROM Pr
        INTERSECT
        SELECT *
        FROM Course
    )
    SELECT 
        CASE
        WHEN (SELECT COUNT(*) FROM Pr) = (SELECT COUNT(*) FROM Intersection)
        THEN 1 
        ELSE 0 END AS PrereqMet
END
GO

---------------------------------
GO
CREATE PROCEDURE checkTimeConflict
    @SID INT,
    @SecID INT,
    @TimeBlock VARCHAR(50),
    @Semester VARCHAR(15)
AS
BEGIN
    IF EXISTS (SELECT *
               FROM ActiveEnrollment as AE 
               WHERE AE.SID = @SID AND AE.Semester = @Semester AND 
               AE.TimeBlock  = @TimeBlock)
    BEGIN 
	SELECT 1 AS Conflict;
    END
    ELSE
    BEGIN
	SELECT 0 AS NoConflict;
    END
END;
GO
---------------------------------
GO
CREATE PROC IsSectionOpen
    @SecID INT,
    @CurrentSemester VARCHAR(50)
AS
BEGIN
SELECT CASE WHEN EXISTS(
    SELECT *
    FROM Section AS S
    WHERE S.SecID = @SecID AND S.Semester = @CurrentSemester AND 
    S.NumEnrolled >= S.MaxCapacity)
THEN CAST(0 AS BIT)
ELSE CAST(1 AS BIT) END
END


