// User Inputs
using System.ComponentModel.Design;

bool check = true;

do
{
    // System check if the value from the user are numeric
    Console.WriteLine("Welcome to the Average Computation\n");
    // User Input for Subj 1
    Console.Write("Enter the grade for Subject 1: ");
    string subj1 = Console.ReadLine();

    // User Input for Subj 2
    Console.Write("Enter the grade for Subject 2: ");
    string subj2 = Console.ReadLine();

    // User Input for Subj 3
    Console.Write("Enter the grade for Subject 3: ");
    string subj3 = Console.ReadLine();

    // System check if the user input is numerical value
    if (int.TryParse(subj1, out int grade1) && (int.TryParse(subj2, out int grade2) && (int.TryParse(subj3, out int grade3))))
    {
        int totalGrade = grade1 + grade2 + grade3;
        int averageGrade = totalGrade / 3;
        Console.WriteLine($"The grade for subj 1 is {grade1}, grade for subj 2 is {grade2} and grade for subj 3 is {grade3}.");
        Console.WriteLine($"The average grade is {averageGrade}.");
    }
    else
    {
        // Catch if the user enter any non numerical value
        Console.WriteLine("Invalid Input. Please enter numeric values for the grades. ");
    }

    Console.WriteLine("Do you like to try again? (Y: Yes): ");
}
while (Console.ReadKey().Key == ConsoleKey.Y);

for (int i = 5; i < 5; i++)
{
    Console.WriteLine("Anyeong");
}