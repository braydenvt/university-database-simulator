-- usage: EXEC LoadXMLData 'C:\filepath\file.xml'
USE [391Project2]
GO
DROP PROCEDURE IF EXISTS LoadXMLData
GO
CREATE PROCEDURE LoadXMLData
    @FilePath NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

            DECLARE @XML XML;
            DECLARE @XMLData NVARCHAR(MAX);
            DECLARE @SQL NVARCHAR(MAX);

            -- have to extract dynamically here, openrowset doesn't support variables
            SET @SQL = 'SELECT @XMLData = BulkColumn FROM OPENROWSET(BULK ''' + @FilePath + ''', SINGLE_CLOB) AS x';
            EXEC sp_executesql @SQL, N'@XMLData NVARCHAR(MAX) OUTPUT', @XMLData OUTPUT;
            SET @XML = CAST(@XMLData AS XML);

            INSERT INTO Date (Semester, Year)
            SELECT DISTINCT
                x.value('(Semester/text())[1]', 'VARCHAR(20)') AS Semester,
                x.value('(Year/text())[1]', 'INT') AS Year
            FROM @XML.nodes('/dataset/Date') AS T(x)
            WHERE NOT EXISTS (
                SELECT 1 FROM Date d
                WHERE d.Semester = x.value('(Semester/text())[1]', 'VARCHAR(20)')
                AND d.Year = x.value('(Year/text())[1]', 'INT')
            );

            INSERT INTO Instructor (InstructorId, Faculty, Rank, University)
            SELECT DISTINCT
                CAST(x.query('InstructorId').value('.','NVARCHAR(50)') AS INT),
                x.value('(Faculty/text())[1]', 'VARCHAR(20)'),
                x.value('(Rank/text())[1]', 'VARCHAR(20)'),
                x.value('(University/text())[1]', 'VARCHAR(30)')
            FROM @XML.nodes('/dataset/Instructor') AS T(x)
            WHERE NOT EXISTS (
                SELECT 1 FROM Instructor i
                WHERE i.InstructorId = CAST(x.query('InstructorId').value('.','NVARCHAR(50)') AS INT)
            );

            INSERT INTO Course (CourseId, Department, Faculty, University)
            SELECT DISTINCT
                CAST(x.query('CourseId').value('.','NVARCHAR(50)') AS INT),
                x.value('(Department/text())[1]', 'VARCHAR(20)'),
                x.value('(Faculty/text())[1]', 'VARCHAR(20)'),
                x.value('(University/text())[1]', 'VARCHAR(30)')
            FROM @XML.nodes('/dataset/Course') AS T(x)
            WHERE NOT EXISTS (
                SELECT 1 FROM Course c
                WHERE c.CourseId = CAST(x.query('CourseId').value('.','NVARCHAR(50)') AS INT)
            );

            INSERT INTO Student (StudentId, Major, Gender)
            SELECT DISTINCT
                CAST(x.query('StudentId').value('.','NVARCHAR(50)') AS INT),
                x.value('(Major/text())[1]', 'VARCHAR(20)'),
                x.value('(Gender/text())[1]', 'VARCHAR(20)')
            FROM @XML.nodes('/dataset/Student') AS T(x)
            WHERE NOT EXISTS (
                SELECT 1 FROM Student s
                WHERE s.StudentId = CAST(x.query('StudentId').value('.','NVARCHAR(50)') AS INT)
            );

            INSERT INTO Enrollment (CourseId, InstructorId, StudentId, DateId, Grade)
            SELECT DISTINCT
                CAST(x.query('CourseId').value('.','NVARCHAR(50)') AS INT),
                CAST(x.query('InstructorId').value('.','NVARCHAR(50)') AS INT),
                CAST(x.query('StudentId').value('.','NVARCHAR(50)') AS INT),
                d.DateId,
                x.value('(Grade/text())[1]', 'VARCHAR(2)')
            FROM @XML.nodes('/dataset/Enrollment') AS T(x)
            JOIN Date d ON d.Semester = x.value('(../Date/Semester/text())[1]', 'VARCHAR(20)')
                        AND d.Year = x.value('(../Date/Year/text())[1]', 'INT')
            WHERE NOT EXISTS (
                SELECT 1 FROM Enrollment e
                WHERE e.CourseId = CAST(x.query('CourseId').value('.','NVARCHAR(50)') AS INT)
                AND e.InstructorId = CAST(x.query('InstructorId').value('.','NVARCHAR(50)') AS INT)
                AND e.StudentId = CAST(x.query('StudentId').value('.','NVARCHAR(50)') AS INT)
                AND e.DateId = d.DateId
            );

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
    END CATCH
END
GO
