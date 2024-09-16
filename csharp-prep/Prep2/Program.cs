using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string ValueFromUser = Console.ReadLine();

        int GradePercentage = int.Parse(ValueFromUser);
        string letter = "F";

        if (GradePercentage >= 90)
        {
           letter = "A";
        }

        else if (GradePercentage >= 80)
        {
           letter = "B";
        }

        else if (GradePercentage >= 70)
        {
           letter = "C";
        }

        else if (GradePercentage >= 60)
        {
           letter = "D";
        }

        else
        {
           letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");
        Console.WriteLine("");
    }
}