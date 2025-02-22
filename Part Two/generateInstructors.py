import random

# Define faculties and their corresponding departments
faculties = {
    "Science": ["Psychology", "Physics", "Chemistry", "Computer Science", "Biology", "Math"],
    "Arts": ["English", "Fine Arts", "Drama", "Film", "History", "Music"],
    "Business": ["Accounting", "Finance", "Economics"],
    "Law": ["Law"]
}

# List of Universities (as provided)
universities = [
    "University of Alberta", "Athabasca University", "University of Calgary",
    "MacEwan University", "NorQuest College", "NAIT", "SAIT",
    "Bow Valley University", "Mount Royal University"
]

# Define ranks and their probabilities (Head is rarer)
ranks = ["Professor", "Associate Professor", "Head"]
rank_weights = [0.45, 0.45, 0.10]  # Head appears ~10% of the time

# Number of instructors to generate
num_instructors = random.randint(100, 160) # Adjust as needed

# Dictionary to track if a department (within a faculty) already has a Head instructor.
# Key: (faculty, department), Value: True/False
head_assigned = {}

# List to store generated instructor lines
instructors = []

for instructor_id in range(1, num_instructors + 1):
    # Choose a faculty
    faculty = random.choice(list(faculties.keys()))
    # Choose a department within the selected faculty
    department = random.choice(faculties[faculty])
    # Choose a rank using weighted probabilities
    chosen_rank = random.choices(ranks, weights=rank_weights, k=1)[0]
    
    # Check if this department already has a head instructor
    dept_key = (faculty, department)
    if chosen_rank == "Head":
        if head_assigned.get(dept_key, False):
            # If a Head is already assigned for this department, choose between Professor and Associate Professor
            chosen_rank = random.choice(["Professor", "Associate Professor"])
        else:
            head_assigned[dept_key] = True  # Mark this department as having a head
    
    # Choose a university from the provided list
    university = random.choice(universities)
    
    # Format the line exactly as requested
    line = f"({instructor_id}, '{faculty}', '{chosen_rank}', '{university}')"
    instructors.append(line)

# Write the records to a file in batches of 1000 entries.
output_file = "instructors_data.txt"
batch_size = 1000

with open(output_file, "w") as f:
    for i in range(0, len(instructors), batch_size):
        batch = instructors[i : i + batch_size]
        # Write the INSERT statement before each batch.
        f.write("INSERT INTO Instructor (InstructorId, Faculty, Rank, University) VALUES\n")
        # Write the batch of records separated by commas and newlines, ending with a semicolon.
        f.write(",\n".join(batch) + ";\n\n")

print(f"Generated {num_instructors} instructors and saved to {output_file}.")