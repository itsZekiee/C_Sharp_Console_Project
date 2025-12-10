💻 C# Console Solutions Archive

A comprehensive collection of C# console applications demonstrating core programming concepts, algorithmic problem-solving, and efficient system I/O handling. This repository serves as a centralized archive of my journey in mastering the .NET environment, ranging from basic syntax exercises to complex logic puzzles.

📖 Overview

This repository acts as a playground for C# development. Each folder contains a standalone solution focusing on specific programming principles such as:

Input Validation: Robust handling of user data (e.g., TryParse, loop constraints).

Control Flow: Mastery of loops (do-while, for), switches, and conditional logic.

Data Structures: Manipulation of arrays, lists, and dictionaries.

Object-Oriented Programming: Implementation of classes, inheritance, and encapsulation.

📂 Project Directory

Project Name

Description

Key Concepts

Average Calculator

Computes the average of 3 grades with validation.

int.TryParse, do-while, String Interpolation

[Project Name]

[Brief description of next project]

[Key concepts used]

[Project Name]

[Brief description of next project]

[Key concepts used]

(Note: This table is updated as new solutions are added.)

🚀 Getting Started

To run any of these solutions locally, ensure you have the .NET SDK installed.

Prerequisites

.NET SDK (Version 6.0 or higher recommended)

Visual Studio or VS Code

Installation

Clone the repository:

git clone [https://github.com/](https://github.com/)[your-username]/[repo-name].git


Navigate to the project directory:

cd [repo-name]/[SpecificProjectFolder]


Build and Run:

dotnet run


📝 Code Example

Here is a snippet from the Average Calculator project demonstrating input validation logic:

// System check if the user input is numerical value
if (int.TryParse(subj1, out int grade1) && 
    int.TryParse(subj2, out int grade2) && 
    int.TryParse(subj3, out int grade3))
{
    int totalGrade = grade1 + grade2 + grade3;
    int averageGrade = totalGrade / 3;
    Console.WriteLine($"The average grade is {averageGrade}.");
}
else
{
    Console.WriteLine("Invalid Input. Please enter numeric values.");
}


👨‍💻 Author

Niel Ezequiel Dungao

Portfolio: zdeveloper.online

Role: BSIT Student @ Polytechnic University of the Philippines

Focus: Front-End Development & Cybersecurity

If you find this repository helpful or interesting, please give it a ⭐️!
