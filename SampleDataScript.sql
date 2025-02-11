USE [391Project]

-- INSERTING STUDENTS
GO
INSERT INTO [dbo].[Student]
VALUES
	('Bryan', 'Hudson', 'Y'),
	('Caleb', 'Ferguson', 'Y'),
	('Tim','Hill', 'Y'),
	('Nick', 'Mears', 'Y'),
	('Ian', 'Hamilton', 'Y'),
	('Sophia', 'Williams', 'Y'),
	('Oliver', 'Johnson', 'Y'),
	('Lily', 'Smith', 'Y'),
	('James', 'Brown', 'Y'),
	('Emma', 'Jones', 'Y'),
	('Lucas', 'Davis', 'Y'),
	('Mia', 'Garcia', 'Y'),
	('William', 'Martinez', 'Y'),
	('Charlotte', 'Rodriguez', 'Y'),
	('Benjamin', 'Wilson', 'Y'),
	('Amelia', 'Anderson', 'Y'),
	('Elijah', 'Taylor', 'Y'),
	('Zoe', 'Thomas', 'Y'),
	('Ethan', 'Moore', 'Y'),
	('Harper', 'Jackson', 'Y'),
	('Alexander', 'White', 'Y'),
	('Isabella', 'Harris', 'Y'),
	('Michael', 'Clark', 'Y'),
	('Avery', 'Lewis', 'Y'), -- #24
	('Avern', 'Lewis', 'N'),
	('Dannn', 'Young', 'N'),
	('Emiln', 'Clark', 'N'),
	('Sydnn', 'Martin', 'N'),
	('Tonin', 'Bennett', 'N')
GO

-- INSERTING DEPARTMENTS 
GO
INSERT INTO [dbo].[Department]
VALUES
	('CMPT', 'Computer Science','Building 5'),
	('MATH','Mathematics','Building 5'),
	('STAT','Statistics', 'Building 5'),
	('ENGL','English' ,'Building 6')
GO

-- INSERTING INSTRUCTOR 

GO
INSERT INTO [dbo].[Instructor]
VALUES
	('Tobias', 'Reider', 'Head', 'CMPT'),
	('Alex', 'Vlasic', 'Sessional', 'CMPT'),
	('Alex', 'Wennberg', 'Associate','CMPT'),
	('Jake','Walman', 'Sessional', 'CMPT'),
	('Thomas', 'Harley', 'Associate', 'CMPT'),
	('Jack', 'Quinn', 'Associate', 'STAT'),
	('Trent', 'Fredric', 'Head', 'STAT'),
	('Nicholas', 'Paul', 'Head', 'ENGL')
GO

-- INSERTING COURSE
GO
INSERT INTO [dbo].[Course]
VALUES
	('CMPT-101','Introduction to Computing I', 'CMPT'),
	('CMPT-103','Introduction to Computing II', 'CMPT'),
	('CMPT-200','Data Structures and Algorithms', 'CMPT'),
	('CMPT-201','Practical Programming Methodology', 'CMPT'),
	('CMPT-250','Introduction to Human Computer Interaction', 'CMPT'),
	('CMPT-305', 'Introduction to Object-Oriented Programming', 'CMPT'),
	('CMPT-315', 'Web Application Development', 'CMPT'),
	('CMPT-291', 'Introduction to Database Management', 'CMPT'),
	('CMPT-104', 'Fluency with Information Technology','CMPT'),
	('CMPT-230', 'Introduction to Computer Games','CMPT'),
	('ENGL-102', 'Analysis and Argument', 'ENGL')
GO

-- INSERTING PREREQ
GO
INSERT INTO [dbo].[Prereq]
VALUES
	('CMPT-103','CMPT-101'),
	('CMPT-200','CMPT-103'),
	('CMPT-201','CMPT-200'),
	('CMPT-250','CMPT-101'),
	('CMPT-305','CMPT-200'),
	('CMPT-291','CMPT-200'),
	('CMPT-315','CMPT-291'),
	('CMPT-315','CMPT-305'),
	('CMPT-230','ENGL-102')
GO

-- INSERTING SECTION
GO
INSERT INTO [dbo].Section
VALUES
	-- CMPT 101
	('Fall 2021', 30, 'F', '6-285','CMPT-101', 4, 9), -- #1
	('Fall 2023', 30, 'F', '6-285','CMPT-101', 4, 9),  
	('Fall 2023', 30, 'M', '5-213', 'CMPT-103', 2,0), -- #3
	('Winter 2024', 30, 'C', '5-121', 'CMPT-103', 1,9),
	('Winter 2022', 30, 'C', '5-121', 'CMPT-103', 1, 9), -- #5
	('Fall 2024', 30, 'L', '5-215', 'CMPT-200', 1,0),
	('Fall 2022', 30, 'A', '5-167', 'CMPT-200', 4, 9), -- #7
	('Winter 2024', 30, 'C', '5-121', 'CMPT-250', 1,9),
	('Winter 2023', 30, 'L', '5-215', 'CMPT-201', 1,9), -- #9
	('Winter 2023', 30, 'A', '5-263', 'CMPT-305', 1,9), 
	('Winter 2023', 30, 'K', '5-321', 'CMPT-291', 3,6), -- #11
	('Winter 2023', 30, 'M', '5-213', 'CMPT-103', 2,0),
	('Fall 2024', 30, 'A', '5-213', 'CMPT-200', 1,0), -- #13
	('Winter 2023', 30, 'B', '6-123', 'ENGL-102',7,9),
	('Winter 2025', 30, 'C', '6-144', 'ENGL-102',7,0), -- #15
	-- TEST MAX
	('Fall 2025', 5, 'A', '5-123', 'ENGL-102',7,5),
	-- Current Semester 
	('Fall 2025', 5, 'A', '7-101', 'CMPT-101', 1, 0),
    ('Fall 2025', 5, 'F', '6-102', 'CMPT-103', 2, 0),
    ('Fall 2025', 4, 'T', '5-201', 'CMPT-200', 3, 0),
    ('Fall 2025', 4, 'V', '9-202', 'CMPT-201', 4, 0),
    ('Fall 2025', 5, 'W', '8-301', 'CMPT-250', 5, 0),
    ('Fall 2025', 5, 'C', '8-302', 'CMPT-305', 6, 0),
    ('Fall 2025', 5, 'D', '7-303', 'CMPT-315', 1, 0),
    ('Fall 2025', 4, 'G', '7-304', 'CMPT-291', 2, 0),
    ('Fall 2025', 6, 'E', '6-305', 'CMPT-104', 3, 0),
    ('Fall 2025', 5, 'H', '5-306', 'CMPT-230', 4, 0),
<<<<<<< HEAD
    ('Fall 2025', 5, 'H', '8-101', 'ENGL-102', 5, 0)
=======
    ('Fall 2025', 5, 'H', '8-101', 'ENGL-102', 5, 1)
>>>>>>> master
GO

-- INSERTING ENROLLMENT
GO 
INSERT INTO [dbo].[Enrollment]
VALUES 
	-- CMPT-101 Fall 2021
	(1,1),
	(2,1),
	(3,1),
	(4,1),
	(5,1),
	(6,1),
	(7,1),
	(8,1),
	(9,1),
	-- CMPT-103 Winter 2022
	(1,5),
	(2,5),
	(3,5),
	(4,5),
	(5,5),
	(6,5),
	(7,5),
	(8,5),
	(9,5),
	-- CMPT-101 Fall 2023 
	(10,2),
	(11,2),
	(12,2),
	(13,2),
	(14,2),
	(15,2),
	(16,2),
	(17,2),
	(18,2),
	(19,2),
	-- CMPT-200 Fall 2022
	(1,7),
	(2,7),
	(3,7),
	(4,7),
	(5,7),
	(6,7),
	(7,7),
	(8,7),
	(9,7),
	-- CMPT-201 Winter 2023
	(1,9),
	(2,9),
	(3,9),
	(4,9),
	(5,9),
	(6,9),
	(7,9),
	(8,9),
	(9,9),
	-- CMPT-103 Winter 2024
	(10,4),
	(11,4),
	(12,4),
	(13,4),
	(14,4),
	(15,4),
	(16,4),
	(17,4),
	(18,4),
	(19,4),
	-- CMPT-250 Winter 2024
	(10,8),
	(11,8),
	(12,8),
	(13,8),
	(14,8),
	(15,8),
	(16,8),
	(17,8),
	(18,8),
	(19,8),
	-- CMPT-305 Winter 2023
	(1,10),
	(2,10),
	(3,10),
	(4,10),
	(5,10),
	(6,10),
	(7,10),
	(8,10),
	(9,10),
	-- CMPT-291 Winter 2023
	(1,11),
	(2,11),
	(3,11),
	(4,11),
	(5,11),
	(6,11),
	-- FOR A TEST CASE STUDENTS 7-9 ONLY HAVE
	-- ONE OF TWO PREREQS for 315
	-- ENGL-102 Winter 2023
	(5,14),
	(6,14),
	(7,14),
	(8,14),
	(9,14),
	(10,14),
	(11,14),
	(12,14),
	(13,14),
	-- MAXED OUT ENGL-102 Fall 2025
	(20,16),
	(21,16),
	(22,16),
	(23,16),
	(24,16)
	-------
	(1,27)
GO











