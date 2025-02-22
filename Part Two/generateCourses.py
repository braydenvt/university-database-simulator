import random

# Define faculties and their corresponding departments
faculties = {
    "Science": ["Psychology", "Physics", "Chemistry", "Computer Science", "Biology", "Math"],
    "Arts": ["English", "Fine Arts", "Drama", "Film", "History", "Music"],
    "Business": ["Accounting", "Finance", "Economics"],
    "Law": ["Law"]
}

# Create a flattened list of (Faculty, Department) pairs for equal weighting
dept_list = []
for faculty, departments in faculties.items():
    for department in departments:
        dept_list.append((faculty, department))

# List of Universities (as provided)
universities = [
    "University of Alberta", "Athabasca University", "University of Calgary",
    "MacEwan University", "NorQuest College", "NAIT", "SAIT",
    "Bow Valley University", "Mount Royal University"
]

# Number of courses to generate
num_courses = random.randint(4000, 10000)  # Adjust as needed

# Generate course data
courses = []
for course_id in range(1000, 1000 + num_courses + 1):
    faculty, department = random.choice(dept_list)
    university = random.choice(universities)
    
    # Format output exactly as required
    courses.append(f"({course_id}, '{department}', '{faculty}', '{university}')")

# Write the records to a file in batches of 1000 entries.
output_file = "courses_data.txt"
batch_size = 1000

with open(output_file, "w") as f:
    for i in range(0, len(courses), batch_size):
        batch = courses[i : i + batch_size]
        # Write the INSERT statement before each batch.
        f.write("INSERT INTO Course (CourseId, Department, Faculty, University) VALUES\n")
        # Write the batch of records separated by commas and newlines, ending with a semicolon.
        f.write(",\n".join(batch) + ";\n\n")

print(f"Generated {num_courses} courses and saved to {output_file}.")