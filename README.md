# University Course Database Simulator
## By Daxton Crowle, Fred Deng, Cole Doris, Stuart Dovey, and Brayden Van Teeling

#### This program has two parts. The first part is a fully featured course enrollment simulator. The second part is a tool that allows for analysis of historical course data.

### Part One

Part one of this project allows the user to enroll in a variety of courses. Upon launching, the first tab shows users the list of available courses. The user can add any of these courses to their cart. 
The user can view the cart tab, which will display all the courses that have been added to the cart. The user can attempt to enroll in any of these courses. Multiple checks are performed to determine if the user is allowed to enroll in a given course. The user cannot enroll in a selected course if any of the following are true:

- The user is currently enrolled in another section of the same course.
- The course presents a time conflict with a course the user is already enrolled in (i.e., the user cannot enroll in two courses that occupy the same time block).
- The user has not taken all of the course's prerequisites in previous semesters. 
- The course is at maximum capacity.

If none of these issues are present, the enrollment is successful, and the selected course is moved from the cart tab to the enrollment tab. Otherwise, the user receives a message informing them that they cannot enroll.
Courses can be removed from the cart or enrollment tabs at any time.

### Part Two

Part two is a tool to interface with a large historical dataset of the enrollment histories of multiple universities. This tool allows the user to display the count of Enrollments, Instructors, Courses, Students, or Dates based on several filters. The user selects as many filters as they would like, the field they want to count, and whether they want the total count of occurrences, or just distinct occurrences. For instance, if a user wanted to know how many courses an instructor with the ID 15 taught in the year 2010, they would input "15" in the "Instructor ID" field, "2010" in the "Year" field, and select "Course" under "Count By." The user then presses "Query," and the count is displayed. 

![image](https://github.com/user-attachments/assets/6f3e5b24-74fd-45e6-a684-bff1390a1ddd)

The user also has the ability to add items to the dataset using an XML file. Here is an example of the format that is expected:

```
<?xml version="1.0" encoding="utf-8"?>
<dataset>
    <Course>
        <CourseID>1000</CourseID>
        <Department>CS</Department>
        <Faculty>Chair</Faculty>
        <University>'MacEwan'</University>
    </Course>
    <Course>
        <CourseID>1001</CourseID>
        <Department>Phys</Department>
        <Faculty>Instructor</Faculty>
        <University>MacEwan</University>
    </Course>
    <Instructor>
        <InstructorID>125</InstructorID>
        <Faculty>COMPUTER SCIENCE</Faculty>
        <Rank>CHAIR</Rank>
        <University>Grant MacEwan</University>
    </Instructor>
</dataset>```
