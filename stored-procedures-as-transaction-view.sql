USE [391Project]

drop view if exists ActiveEnrollment
drop view if exists CourseOfferings
drop procedure if exists UpdateEnrollmentCount
drop procedure if exists checkPrereq
drop procedure if exists checkTimeConflict
drop procedure if exists IsSectionOpen
drop procedure if exists FillSearch
drop procedure if exists EnrolFromCart
drop procedure if exists FillStudentEnrollment
drop procedure if exists addToCart
drop procedure if exists deleteFromCart
drop procedure if exists Unenroll

------------------- ACTIVE ENROLLMENT -------------------
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


------------------- COURSE OFFERINGS -------------------
GO
CREATE VIEW  CourseOfferings
WITH SCHEMABINDING
AS 
	SELECT C.CID, C.Title, S.SecID, S.Semester, C.DID, S.TimeBlock
	FROM dbo.Section as S, dbo.Course as C
	WHERE S.CID = C.CID AND S.Semester = 'Fall 2025'
GO

-- Create an index on the view.
CREATE UNIQUE CLUSTERED INDEX IDX_CourseOfferings
   ON CourseOfferings(SecID);


------------------- CHECK PREREQS -------------------
GO
CREATE PROC checkPrereq
    @SID INT,
    @CID VARCHAR(8),
    @Semester VARCHAR(15)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
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
            ELSE 0 
        END AS PrereqMet;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
           ROLLBACK TRANSACTION;
    END CATCH
END
GO

------------------- IS SECTION OPEN -------------------
GO
CREATE PROCEDURE IsSectionOpen
    @SecID INT,
    @CurrentSemester VARCHAR(50),
	@RETURNVALUE bit output
AS
BEGIN
	BEGIN Try
		BEGIN Transaction
			SELECT @RETURNVALUE = CASE WHEN EXISTS( --took me too long to realize i need to insert an output variable here
			SELECT *
			FROM Section AS S
			WHERE S.SecID = @SecID AND S.Semester = @CurrentSemester AND --should not be necessary to specify semester. SecID for cmpt101fall '23 should not be the same as for cmpt101 win '24, for instance. -cole
			S.NumEnrolled >= S.MaxCapacity)
			THEN CAST(0 AS BIT)
			ELSE CAST(1 AS BIT) END
		COMMIT Transaction
	END Try
	BEGIN Catch
		Rollback Transaction
	END Catch
END
GO

------------------- FILL SEARCH -------------------
GO
CREATE PROC FillSearch
	@Semester VARCHAR(15),
	@DepartmentID VARCHAR(4) = NULL,
	@CID VARCHAR(8) = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			SELECT * 
			FROM CourseOfferings
			WHERE (@CID IS NULL OR CID = @CID) AND
			(@DepartmentID IS NULL OR DID = @DepartmentID)
		COMMIT TRANSACTION
	END TRY
	BEGIN Catch
		Rollback Transaction
	END Catch
END
GO


------------------- UPDATE SECTION COUNT -------------------
go
create procedure UpdateEnrollmentCount
	@SecID INT
as
begin
	begin try
		begin transaction
			update Section set NumEnrolled = (select count(*) from Enrollment where SecID = @SecID) WHERE SecID = @SecID
		commit transaction
	end try
	begin catch
		rollback transaction
	end catch
end
go

 ------------------- ENROLL STUDENT -------------------
go 
create proc EnrolFromCart
	@SecID INT,
	@CurrentSemester VARCHAR(50),
	@SID INT
as 
begin
	begin try 
		begin transaction
			declare @result bit;
			exec IsSectionOpen @SecID = @SecID, @CurrentSemester = @CurrentSemester, @RETURNVALUE = @result OUTPUT;
			--nightmare nightmare nightmare nightmare nightmare nightmare nightmare nightmare nightmare nightmare 
			if (@result = 1) begin
				insert into enrollment (SID, SecID) values (@SID, @SecID)
				delete from cart where SID = @SID and SecID = @SecID
				exec UpdateEnrollmentCount @SecID = @SecID
				Select 1 as Result;
			end
			ELSE
			BEGIN
				Select 0 AS Result;
			END
		commit transaction
	end try 
	begin catch
	
		Rollback Transaction

	end catch
end
go
------------------- UN ENROLL -------------------
GO
CREATE PROC Unenroll
	@SecID INT,
	@SID INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION; 
			
			DELETE FROM Enrollment
			WHERE SID = @SID AND SecID = @SecID;
			
			UPDATE Section 
			SET NumEnrolled = (select count(*) from Enrollment where SecID = @SecID) 
			WHERE SecID = @SecID;
			
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH
END
GO

------------------- FILL STUDENT ENROLLMENT -------------------
GO
CREATE PROC FillStudentEnrollment
	@Semester VARCHAR(15),
	@SID INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			SELECT * 
			FROM ActiveEnrollment as A, CourseOfferings as C 
			WHERE A.SecID = C.SecID AND SID = @SID AND A.Semester = @Semester
		COMMIT TRANSACTION
	END TRY
	BEGIN Catch
		Rollback Transaction
	END Catch
END
GO

------------------- CHECK TIME CONFLICT -------------------
GO
CREATE PROCEDURE checkTimeConflict
    @SID INT,
    @SecID INT,
    @TimeBlock VARCHAR(1),
    @Semester VARCHAR(15)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        SELECT COALESCE(
		(SELECT S.SecID AS ConflictSecID
        FROM Enrollment AS E
        JOIN Section AS S ON E.SecID = S.SecID
        WHERE E.SID = @SID
          AND S.Semester = @Semester
          AND S.TimeBlock = @TimeBlock), 0) AS ConflictSecID
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback on error
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
 ------------------- ADD TO CART -------------------
GO
CREATE PROC addToCart
    @SID INT,
    @SecID INT
AS
BEGIN
	BEGIN Try
		BEGIN Transaction
			INSERT INTO Cart (SID, SecID) 
			VALUES (@SID, @SecID)
		COMMIT Transaction
	END Try
	BEGIN Catch
		Rollback Transaction
	END Catch
END
GO

------------------- DELETE FROM CART -------------------
GO
CREATE PROC deleteFromCart
    @SID INT,
    @SecID INT
AS
BEGIN
	BEGIN Try
		BEGIN Transaction
			IF EXISTS(SELECT 1 FROM Cart WHERE SID = @SID AND SecID = @SecID)
			BEGIN
				DELETE FROM Cart WHERE SID = @SID AND SecID = @SecID
			END
		COMMIT Transaction
	END Try
	BEGIN Catch
		Rollback Transaction
	END Catch
END
GO