-- Selects the most recent files (used in part 3 demo)

use [391Project2]

SELECT TOP 10 *
FROM Date
ORDER BY DateId DESC

SELECT TOP 10 *
FROM Course
ORDER BY CourseId DESC

SELECT TOP 10 *
FROM Instructor
ORDER BY InstructorId DESC

SELECT TOP 10 *
FROM Student
ORDER BY StudentId DESC

SELECT TOP 10 *
FROM Enrollment
ORDER BY StudentId
