using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string ValueFromUser = Console.ReadLine();

        int GradePercentage = int.Parse(ValueFromUser);
        string letter = "F";
        bool passed = false;

        if (GradePercentage >= 90)
        {
           letter = "A";
           passed = true;
        }

        else if (GradePercentage >= 80)
        {
           letter = "B";
           passed = true;
        }

        else if (GradePercentage >= 70)
        {
           letter = "C";
           passed = true;
        }

        else if (GradePercentage >= 60)
        {
           letter = "D";
        }

        else
        {
           letter = "F";
        }


        if (passed == true)
        {
            Console.WriteLine($"Your grade is {letter}. You passed! Congratulations!");
        }

        else
        {
            Console.WriteLine($"Your grade is {letter}. Better luck next time!");
        }
        Console.WriteLine("");
    }
}