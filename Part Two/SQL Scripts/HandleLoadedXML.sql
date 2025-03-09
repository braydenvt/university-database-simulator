-- SQL file to handle the inseriton of the XML file into the SQL tables.
-- FILEPATH needs to be specified to ensure it runs.
-- XML file needs to be structed in the fashion below.
-- <?xml version="1.0" encoding="utf-8"?>
-- <dataset>
--     <Course>
--         <CourseID>1000</CourseID>
--         <Department>CS</Department>
--         <Faculty>Chair</Faculty>
--         <University>'MacEwan'</University>
--     </Course>
--     <Instructor>
--         <InstructorID>125</InstructorID>
--         <Faculty>COMPUTER SCIENCE</Faculty>
--         <Rank>CHAIR</Rank>
--         <University>Grant MacEwan</University>
--     </Instructor>
--     ...
-- </dataset>

INSERT INTO Courses (CourseId, Department, Faculty, University)
SELECT 
    Dat.Course.query('CourseId').value('.', 'INT') as CourseId,
    Dat.Course.query('Department').value('.', 'varchar(20)') as Department,
    Dat.Course.query('Faculty').value('.', 'varchar(20)') as Faculty,
    Dat.Course.query('University').value('.', 'varchar(30)') as University
FROM 
(
    SELECT CAST(MY_XML AS xml) FROM
    OPENROWSET(
        BULK 'FILEPATH', 
        SINGLE_BLOB
    ) AS T(MY_XML)
) AS S(MY_XML)
CROSS APPLY MY_XML.nodes('dataset/Course') AS Dat(Course);

INSERT INTO Instructor (InstructorId, Faculty, Rank, University)
SELECT 
    Dat.Instructor.query('InstructorId').value('.', 'INT') as InstructorId,
    Dat.Instructor.query('Faculty').value('.', 'varchar(20)') as Faculty,
    Dat.Instructor.query('Rank').value('.', 'varchar(20)') as Rank,
    Dat.Instructor.query('University').value('.', 'varchar(30)') as University
FROM 
(
    SELECT CAST(MY_XML AS xml) FROM
    OPENROWSET(
        BULK 'FILEPATH', 
        SINGLE_BLOB
    ) AS T(MY_XML)
) AS S(MY_XML)
CROSS APPLY MY_XML.nodes('dataset/Instructor') AS Dat(Instructor);

INSERT INTO Student (StudentId, Major, Gender)
SELECT 
    Dat.Student.query('StudentId').value('.', 'INT') as StudentId,
    Dat.Student.query('Major').value('.', 'varchar(20)') as Major,
    Dat.Student.query('Gender').value('.', 'varchar(20)') as Gender
FROM 
(
    SELECT CAST(MY_XML AS xml) FROM
    OPENROWSET(
        BULK 'FILEPATH', 
        SINGLE_BLOB
    ) AS T(MY_XML)
) AS S(MY_XML)
CROSS APPLY MY_XML.nodes('dataset/Student') AS Dat(Student);

INSERT INTO Date (DateId, Semester, Year)
SELECT 
    Dat.Date.query('DateId').value('.', 'INT') as DateId,
    Dat.Date.query('Semester').value('.', 'varchar(20)') as Semester,
    Dat.Date.query('Year').value('.', 'INT') as Year
FROM 
(
    SELECT CAST(MY_XML AS xml) FROM
    OPENROWSET(
        BULK 'FILEPATH', 
        SINGLE_BLOB
    ) AS T(MY_XML)
) AS S(MY_XML)
CROSS APPLY MY_XML.nodes('dataset/Date') AS Dat(Date);

INSERT INTO Enrollment (CourseId, InstructorId, StudentId, DateId, Grade)
SELECT 
    Dat.Enrollment.query('CourseId').value('.', 'INT') as CourseId,
    Dat.Enrollment.query('InstructorId').value('.', 'INT') as InstructorId,
    Dat.Enrollment.query('StudentId').value('.', 'INT') as StudentId,
    Dat.Enrollment.query('DateId').value('.', 'INT') as DateId,
    Dat.Enrollment.query('Grade').value('.', 'varchar(2)') as Grade
FROM 
(
    SELECT CAST(MY_XML AS xml) FROM
    OPENROWSET(
        BULK 'FILEPATH', 
        SINGLE_BLOB
    ) AS T(MY_XML)
) AS S(MY_XML)
CROSS APPLY MY_XML.nodes('dataset/Enrollment') AS Dat(Enrollment);
