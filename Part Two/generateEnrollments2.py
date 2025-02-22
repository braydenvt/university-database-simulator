import random, math

# Predefined faculties and their departments.
faculties = {
    "Science": ["Psychology", "Physics", "Chemistry", "Computer Science", "Biology", "Math"],
    "Arts": ["English", "Fine Arts", "Drama", "Film", "History", "Music"],
    "Business": ["Accounting", "Finance", "Economics"],
    "Law": ["Law"]
}

# ---------------------------
# Utility Functions
# ---------------------------

def extract_courses_by_university(filename):
    """
    Reads courses_data.txt which is assumed to have lines like:
      (CourseId, 'Department', 'Faculty', 'University'),
    and returns a dictionary mapping university -> list of course tuples.
    Each course tuple is: (course_id, department, faculty, university)
    """
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
    """
    Reads Students_data.txt which is assumed to have lines like:
      (StudentId, 'Major', 'Gender'),
    and returns a dictionary mapping student_id -> major.
    """
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
    """
    Reads instructors_data.txt which is assumed to have lines like:
      (InstructorId, 'Faculty', 'Rank', 'University'),
    and returns a dictionary mapping faculty -> list of instructor tuples.
    Each instructor tuple is: (instructor_id, faculty, rank, university)
    """
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
    """
    Chooses a student ID using a normal distribution over the indices.
    """
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
courses_by_univ = extract_courses_by_university("courses_data.txt")
instructors_by_faculty = extract_instructors_by_faculty("instructors_data.txt")
student_data = extract_student_data("Students_data.txt")  # student_id -> major
student_ids_list = list(student_data.keys())

available_universities = list(courses_by_univ.keys())
if not available_universities:
    raise Exception("No courses found in courses_data.txt.")

# ---------------------------
# DateId Setup (same as before)
# ---------------------------
all_dates = list(range(1, 65))
preferred = [1, 2, 5, 6, 9, 10, 13, 14, 17, 18, 21, 22, 25, 26, 29, 30, 33, 34, 37, 38, 41, 42, 45, 46, 49, 50, 53, 54, 57, 58, 61, 62]
date_weights = [4 if d in preferred else 1 for d in all_dates]

# ---------------------------
# Enrollment Record Generation
# ---------------------------
num_records = random.randint(600000, 900000)  # Adjust as needed
enrollment_records = []

# Tracking dictionaries:
student_university = {}    # student_id -> university
student_cluster = {}       # student_id -> cluster center (for DateId)
student_date_count = {}    # (student_id, date_id) -> count
student_enrollments = {}   # student_id -> set of course_ids already enrolled

sigma_cluster = 8   # For DateId clustering.
sigma_major = 2.0   # For course selection around student's major (decreased weight effect).

for _ in range(num_records):
    # Choose a student (normally distributed by index).
    student_id = choose_student_id(student_ids_list)
    student_major = student_data[student_id]
    
    # Determine the student's faculty based on their major.
    student_faculty = None
    student_major_index = None
    for fac, dept_list in faculties.items():
        if student_major in dept_list:
            student_faculty = fac
            student_major_index = dept_list.index(student_major)
            break
    
    # Assign a university to the student if not already assigned.
    if student_id not in student_university:
        student_university[student_id] = random.choice(available_universities)
    student_univ = student_university[student_id]
    
    # From the courses offered at the student's university, filter to those in the student's faculty.
    candidate_courses = []
    if student_faculty:
        for course in courses_by_univ.get(student_univ, []):
            if course[2] == student_faculty:
                candidate_courses.append(course)
    # If no candidate courses are found in that faculty, fallback to all courses from that university.
    if not candidate_courses:
        candidate_courses = courses_by_univ.get(student_univ, [])
    
    # Weight courses based on how "close" their department is to the student's major.
    weights = []
    if student_faculty and candidate_courses:
        dept_list = faculties[student_faculty]
        for course in candidate_courses:
            try:
                idx = dept_list.index(course[1])
            except ValueError:
                idx = len(dept_list)
            weight = math.exp(-0.5 * ((idx - student_major_index) / sigma_major) ** 2)
            weights.append(weight)
    else:
        weights = [1] * len(candidate_courses)
    
    # Choose a course using the computed weights.
    if candidate_courses:
        chosen_course = random.choices(candidate_courses, weights=weights, k=1)[0]
        course_id = chosen_course[0]
        course_faculty = chosen_course[2]
    else:
        course_id = None
        course_faculty = None

    # Enforce that the student is not enrolled in the same course more than once.
    if student_id not in student_enrollments:
        student_enrollments[student_id] = set()
    if course_id in student_enrollments[student_id]:
        continue  # Skip if already enrolled in this course.
    
    # Choose an instructor whose faculty matches the course's faculty.
    if course_faculty and course_faculty in instructors_by_faculty and instructors_by_faculty[course_faculty]:
        chosen_instructor = random.choice(instructors_by_faculty[course_faculty])
        instructor_id = chosen_instructor[0]
    else:
        # Fallback: if no instructor available for that faculty, choose a random instructor from all faculties.
        all_instructors = [ins[0] for fac in instructors_by_faculty for ins in instructors_by_faculty[fac]]
        instructor_id = random.choice(all_instructors) if all_instructors else None

    # Generate a DateId using a normal distribution centered on a student-specific cluster.
    if student_id not in student_cluster:
        student_cluster[student_id] = random.randint(1, 64)
    center = student_cluster[student_id]
    date_id = int(random.gauss(center, sigma_cluster))
    while date_id < 1 or date_id > 64:
        date_id = int(random.gauss(center, sigma_cluster))
    
    # Ensure no student gets more than 6 courses with the same DateId.
    key = (student_id, date_id)
    attempt = 0
    while student_date_count.get(key, 0) >= 6:
        attempt += 1
        date_id = int(random.gauss(center, sigma_cluster))
        while date_id < 1 or date_id > 64:
            date_id = int(random.gauss(center, sigma_cluster))
        key = (student_id, date_id)
        if attempt > 10:
            break
    student_date_count[key] = student_date_count.get(key, 0) + 1

    # Record that this student has enrolled in this course.
    student_enrollments[student_id].add(course_id)
    
    # Format the enrollment record.
    record = f"({course_id}, {instructor_id}, {student_id}, {date_id})"
    enrollment_records.append(record)

# ---------------------------
# Write to Output File in Batches of 1000
# ---------------------------
output_file = "enrollments_data.txt"
batch_size = 1000

with open(output_file, "w") as f:
    for i in range(0, len(enrollment_records), batch_size):
        batch = enrollment_records[i : i + batch_size]
        f.write("INSERT INTO Enrollment (CourseId, InstructorId, StudentId, DateId) VALUES\n")
        f.write(",\n".join(batch) + ";\n\n")

print(f"Generated {len(enrollment_records)} enrollment records and saved to {output_file}.")