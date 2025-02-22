import random

# Define departments that can serve as majors
departments = [
    "Psychology", "Physics", "Chemistry", "Computer Science", "Biology", "Math",
    "English", "Fine Arts", "Drama", "Film", "History", "Music",
    "Accounting", "Finance", "Economics",
    "Law"
]

# Define gender options with weights (Non-binary is rare)
genders = ["Male", "Female", "Non-binary"]
gender_weights = [0.49, 0.49, 0.02]

# Number of students to generate (adjust as needed)
num_students = random.randint(10000, 20000) # Adjust as needed

# Generate student records
students = []
for student_id in range(100000, num_students + 100000 + 1):
    major = random.choice(departments)
    gender = random.choices(genders, weights=gender_weights, k=1)[0]
    # Format: (StudentId, Major, Gender)
    record = f"({student_id}, '{major}', '{gender}')"
    students.append(record)

# # Save the records to a file in the specified format
# file_path = "students_data.txt"
# with open(file_path, "w") as file:
#     file.write("INSERT INTO Student (StudentId, Major, Gender) VALUES\n")
#     file.write(",\n".join(students) + ",\n")

# Write the records to a file in batches of 1000 entries.
output_file = "students_data.txt"
batch_size = 1000

with open(output_file, "w") as f:
    for i in range(0, len(students), batch_size):
        batch = students[i : i + batch_size]
        # Write the INSERT statement before each batch.
        f.write("INSERT INTO Student (StudentId, Major, Gender) VALUES\n")
        # Write the batch of records separated by commas and newlines, ending with a semicolon.
        f.write(",\n".join(batch) + ";\n\n")

print(f"Generated {num_students} students and saved to {output_file}.")