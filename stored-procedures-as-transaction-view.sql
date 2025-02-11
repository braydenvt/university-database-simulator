USE [391Project]

drop view if exists ActiveEnrollment
drop procedure if exists UpdateEnrollmentCount
drop procedure if exists checkPrereq
drop procedure if exists checkTimeConflict
drop procedure if exists IsSectionOpen
drop procedure if exists FillSearch
drop procedure if exists EnrolFromCart

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
	BEGIN Try
		BEGIN Transaction
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
		COMMIT Transaction
	END Try
	BEGIN Catch
		Rollback Transaction
	END Catch
END;
GO
---------------------------------
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

-----------------------------------------------
GO
CREATE PROC FillSearch
	@Semester VARCHAR(15),
	@DepartmentID VARCHAR(4) = NULL,
	@CID VARCHAR(8) = NULL
AS
BEGIN
	SELECT * 
	FROM Section as S, Course as C
	WHERE S.CID = C.CID AND 
	(@CID IS NULL OR S.CID = @CID) AND
	(@DepartmentID IS NULL OR C.DID = @DepartmentID) AND
	S.Semester = @Semester
END
GO

--------------------------------------------

go
create procedure UpdateEnrollmentCount
	@SecID INT
as
begin
	begin try
		begin transaction
			update Section set NumEnrolled = (select count(*) from Enrollment where SecID = @SecID)
		commit transaction
	end try
	begin catch
		rollback transaction
	end catch
end
go

--------------------------------------------

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
				--print 'success';
			end


		commit transaction
	end try 
	begin catch
	
		Rollback Transaction

	end catch
end
go

----------------------------------------------------

