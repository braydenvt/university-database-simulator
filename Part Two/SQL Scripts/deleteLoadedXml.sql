USE [391Project2]
GO
DROP PROCEDURE IF EXISTS DeleteLoadedXml

GO
CREATE PROCEDURE DeleteLoadedXml
AS
BEGIN
	BEGIN Try
		BEGIN Transaction

            DELETE FROM dbo.Date
            WHERE DateId >= 49;
		
            DELETE FROM dbo.Instructor 
            WHERE InstructorId >= 1000;

            DELETE FROM dbo.Course 
            WHERE CourseId >= 10000;

            DELETE FROM dbo.Student 
            WHERE StudentId >= 200000;

            -- This is probably not necessary because of the cascading delete constraints

            -- DELETE FROM dbo.Enrollment
            -- WHERE CourseId >= 10000
            -- OR InstructorId >= 1000
            -- OR StudentId >= 200000
            -- OR DateId >= 49;

		COMMIT Transaction
	END Try
	BEGIN Catch
		Rollback Transaction
	END Catch
END
GO