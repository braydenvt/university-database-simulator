import random, math

# Predefined faculties and their departments.
faculties = {
    "Science": ["Psychology", "Physics", "Chemistry", "Computer Science", "Biology", "Math"],
    "Arts": ["English", "Fine Arts", "Drama", "Film", "History", "Music"],
    "Business": ["Accounting", "Finance", "Economics"],
    "Law": ["Law"]
}

# ---------------------------
# Grading System with Normal Distribution
# ---------------------------
grade_scale = {
    4.3: "A+", 4.0: "A", 3.7: "A-",
    3.3: "B+", 3.0: "B", 2.7: "B-",
    2.3: "C+", 2.0: "C", 1.7: "C-"
}
grade_values = list(grade_scale.keys())

# Parameters for normal distribution of grades
mu_grade = 3.0  # Mean grade is B
sigma_grade = 1.5  # Spread of grades

def generate_grade():
    """Generate a grade using a normal distribution centered around 'B'."""
    grade_value = round(random.gauss(mu_grade, sigma_grade), 1)
    grade_value = min(max(grade_values), max(min(grade_values), grade_value))  # Clamp value within range
    return grade_scale.get(grade_value, "B")  # Default to 'B' if unexpected value

# ---------------------------
# Utility Functions
# ---------------------------

def extract_courses_by_university(filename):
    """ Reads courses_data.sql and returns a dictionary mapping university -> list of course tuples. """
    courses_by_univ = {}
    with open(filename, "r") as f:
        for line in f:
            line = line.strip()
            if not line.startswith("("):
                continue
            line = line.lstrip("(").rstrip(",)").strip()
            tokens = line.split(",")
            if len(tokens) < 4:
                continue
            try:
                course_id = int(tokens[0].strip())
            except ValueError:
                continue
            department = tokens[1].strip().strip("'\"")
            course_faculty = tokens[2].strip().strip("'\"")
            university = tokens[3].strip().strip("'\"")
            course = (course_id, department, course_faculty, university)
            courses_by_univ.setdefault(university, []).append(course)
    return courses_by_univ

def extract_student_data(filename):
    """ Reads Students_data.sql and returns a dictionary mapping student_id -> major. """
    student_data = {}
    with open(filename, "r") as f:
        for line in f:
            line = line.strip()
            if not line.startswith("("):
                continue
            line = line.lstrip("(").rstrip(",)").strip()
            tokens = line.split(",")
            if len(tokens) < 3:
                continue
            try:
                student_id = int(tokens[0].strip())
            except ValueError:
                continue
            major = tokens[1].strip().strip("'\"")
            student_data[student_id] = major
    return student_data

def extract_instructors_by_faculty(filename):
    """ Reads instructors_data.sql and returns a dictionary mapping faculty -> list of instructor tuples. """
    instructors_by_faculty = {}
    with open(filename, "r") as f:
        for line in f:
            line = line.strip()
            if not line.startswith("("):
                continue
            line = line.lstrip("(").rstrip(",)").strip()
            tokens = line.split(",")
            if len(tokens) < 4:
                continue
            try:
                instructor_id = int(tokens[0].strip())
            except ValueError:
                continue
            faculty_val = tokens[1].strip().strip("'\"")
            rank = tokens[2].strip().strip("'\"")
            university_val = tokens[3].strip().strip("'\"")
            record = (instructor_id, faculty_val, rank, university_val)
            instructors_by_faculty.setdefault(faculty_val, []).append(record)
    return instructors_by_faculty

def choose_student_id(student_ids):
    """ Chooses a student ID using a normal distribution over the indices. """
    n = len(student_ids)
    mu = n / 2
    sigma = n / 6
    index = int(random.gauss(mu, sigma))
    while index < 0 or index >= n:
        index = int(random.gauss(mu, sigma))
    return student_ids[index]

# ---------------------------
# Data Extraction
# ---------------------------
courses_by_univ = extract_courses_by_university("courses_data.sql")
instructors_by_faculty = extract_instructors_by_faculty("instructors_data.sql")
student_data = extract_student_data("Students_data.sql")
student_ids_list = list(student_data.keys())

available_universities = list(courses_by_univ.keys())
if not available_universities:
    raise Exception("No courses found in courses_data.sql.")

# ---------------------------
# DateId Setup
# ---------------------------
all_dates = list(range(1, 49))
preferred = [1, 2, 4, 5, 7, 8, 10, 11, 13, 14, 16, 17, 19, 20, 22, 23, 25, 26, 28, 29, 31, 32, 34, 35, 37, 38, 40, 41, 43, 44, 46, 47]
date_weights = [3 if d in preferred else 1 for d in all_dates]

# ---------------------------
# Enrollment Record Generation
# ---------------------------
num_records = random.randint(300000, 400000)
enrollment_records = []

# Tracking dictionaries:
student_university = {}
student_cluster = {}
student_date_count = {}
student_enrollments = {}

sigma_cluster = 2
sigma_major = 2.0  

for _ in range(num_records):
    student_id = choose_student_id(student_ids_list)
    student_major = student_data[student_id]

    # Assign university to student
    if student_id not in student_university:
        student_university[student_id] = random.choice(available_universities)
    student_univ = student_university[student_id]

    # Select a course matching student's faculty
    candidate_courses = [c for c in courses_by_univ.get(student_univ, [])]
    if not candidate_courses:
        continue  

    chosen_course = random.choice(candidate_courses)
    course_id = chosen_course[0]
    course_faculty = chosen_course[2]

    if student_id not in student_enrollments:
        student_enrollments[student_id] = set()
    if course_id in student_enrollments[student_id]:
        continue  

    # Select an instructor matching the faculty of the course
    instructor_list = instructors_by_faculty.get(course_faculty, [])
    if instructor_list:
        instructor_id = random.choice(instructor_list)[0]
    else:
        all_instructors = [ins[0] for fac in instructors_by_faculty for ins in instructors_by_faculty[fac]]
        instructor_id = random.choice(all_instructors) if all_instructors else None

    # Generate DateId
    if student_id not in student_cluster:
        student_cluster[student_id] = random.randint(1, 64)
    center = student_cluster[student_id]
    date_id = int(random.gauss(center, sigma_cluster))
    while date_id < 1 or date_id > 64:
        date_id = int(random.gauss(center, sigma_cluster))

    student_enrollments[student_id].add(course_id)

    grade = generate_grade()
    record = f"({course_id}, {instructor_id}, {student_id}, {date_id}, '{grade}')"
    enrollment_records.append(record)

# ---------------------------
# Write to Output File
# ---------------------------
output_file = "enrollments_data.sql"
batch_size = 1000

with open(output_file, "w") as f:
    for i in range(0, len(enrollment_records), batch_size):
        batch = enrollment_records[i : i + batch_size]
        f.write("INSERT INTO Enrollment (CourseId, InstructorId, StudentId, DateId, Grade) VALUES\n")
        f.write(",\n".join(batch) + ";\n\n")

print(f"Generated {len(enrollment_records)} enrollment records with normally distributed grades and saved to {output_file}.")