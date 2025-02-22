# Define the semesters (no weights used)
semesters = ["Fall", "Winter", "Spring", "Summer"]

# Define the range of years (2009 to 2024 inclusive)
years = list(range(2009, 2025))

# Generate all combinations of (Semester, Year)
combinations = []
for year in years:
    for sem in semesters:
        combinations.append(f"('{sem}', {year})")

# Write the combinations to a file in the requested format
output_file = "dates_data.txt"
with open(output_file, "w") as f:
    f.write("INSERT INTO Date (Semester, Year) VALUES\n")
    f.write(",\n".join(combinations) + ";\n\n")

print(f"Generated {len(combinations)} records and saved to {output_file}.")