using System;
using System.Collections.Generic;
using System.Linq;

// --- 1. The Student Class (Defines the structure/Row) ---
public class Student
{
    // These are the 'columns' of our conceptual 2D array.
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Grade { get; set; }

    public Student(int id, string name, string grade)
    {
        StudentId = id;
        Name = name;
        Grade = grade;
    }

    public override string ToString()
    {
        // Simple formatting for display
        return $"| {StudentId,-4} | {Name,-20} | {Grade,-5} |";
    }
}

// --- 2. The Main Application and Data Structure ---
public class Program
{
    // This List of Student objects is our dynamic 2D array.
    private static List<Student> studentRecords = new List<Student>();
    private static int nextId = 1; // Simple counter for automatic ID assignment

    public static void Main(string[] args)
    {
        Console.WriteLine("|| ============= || DEMO PROJECT || ============= ||");
        Console.WriteLine("|| ============= || CLASS & LIST IMPLEMENTATION || ============= ||");

        // Add a couple of initial records for testing
        studentRecords.Add(new Student(nextId++, "Alice Johnson", "A"));
        studentRecords.Add(new Student(nextId++, "Bob Smith", "B+"));

        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateRecord(); break;
                case "2": ReadRecords(); break;
                case "3": UpdateRecord(); break;
                case "4": DeleteRecord(); break;
                case "5":
                    Console.WriteLine("\n👋 Exiting the Student Record System. Goodbye!");
                    return;
                default: Console.WriteLine("Invalid choice. Please enter a number between 1 and 5."); break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\n==============================");
        Console.WriteLine("   🎓 Simple Student Record");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Create New Record (C)");
        Console.WriteLine("2. View All Records (R)");
        Console.WriteLine("3. Update Record (U)");
        Console.WriteLine("4. Delete Record (D)");
        Console.WriteLine("5. Exit");
        Console.WriteLine("------------------------------");
        Console.Write("Enter your choice (1-5): ");
    }

    // --- CRUD Operations ---

    // 1. CREATE
    private static void CreateRecord()
    {
        Console.WriteLine("\n--- ➕ Add New Student ---");
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Grade (e.g., A, B, C): ");
        string grade = Console.ReadLine();

        // Create a new Student object
        Student newStudent = new Student(nextId, name, grade);
        // Add the object to our List (the "2D array")
        studentRecords.Add(newStudent);

        Console.WriteLine($"Success! Record created for {name} with ID: {nextId}");
        nextId++; // Increment the ID counter
    }

    // 2. READ
    private static void ReadRecords()
    {
        Console.WriteLine("\n--- All Student Records ---");
        if (!studentRecords.Any())
        {
            Console.WriteLine("No records found.");
            return;
        }

        // Print header
        Console.WriteLine($"| {"ID",-4} | {"Name",-20} | {"Grade",-5} |");
        Console.WriteLine(new string('-', 37));

        // Iterate through the List and print each Student's string representation
        foreach (var student in studentRecords)
        {
            Console.WriteLine(student.ToString());
        }
    }

    // 3. UPDATE
    private static void UpdateRecord()
    {
        Console.WriteLine("\n--- Update Student Record ---");
        Console.Write("Enter ID of student to update: ");
        if (!int.TryParse(Console.ReadLine(), out int recordId))
        {
            Console.WriteLine("Invalid input. Please enter a number for the ID.");
            return;
        }

        // Use LINQ's Find method to search for the object
        Student foundStudent = studentRecords.Find(s => s.StudentId == recordId);

        if (foundStudent != null)
        {
            Console.WriteLine($"Found: {foundStudent}");

            Console.Write($"Enter New Name (Current: {foundStudent.Name}, leave blank to skip): ");
            string newName = Console.ReadLine();

            Console.Write($"Enter New Grade (Current: {foundStudent.Grade}, leave blank to skip): ");
            string newGrade = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newName))
            {
                foundStudent.Name = newName;
            }

            if (!string.IsNullOrWhiteSpace(newGrade))
            {
                foundStudent.Grade = newGrade;
            }

            Console.WriteLine($"Success! Record ID {recordId} updated.");
        }
        else
        {
            Console.WriteLine($"Record with ID {recordId} not found.");
        }
    }

    // 4. DELETE
    private static void DeleteRecord()
    {
        Console.WriteLine("\n--- Delete Student Record ---");
        Console.Write("Enter ID of student to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int recordId))
        {
            Console.WriteLine("Invalid input. Please enter a number for the ID.");
            return;
        }

        // Remove the student using the List's RemoveAll method
        int recordsRemoved = studentRecords.RemoveAll(s => s.StudentId == recordId);

        if (recordsRemoved > 0)
        {
            Console.WriteLine($"Success! Record ID {recordId} deleted.");
        }
        else
        {
            Console.WriteLine($"Record with ID {recordId} not found");
        }
    }
}