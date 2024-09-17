using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        int LargestNumber = -1;
        int UserNumbers = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
        

        do
        {
            Console.Write("What is your number? ");
            string UserInput = Console.ReadLine();
            UserNumbers = int.Parse(UserInput);

            if (UserNumbers != 0)
            {
                numbers.Add(UserNumbers);
            }

            if (LargestNumber < UserNumbers)
            {
                LargestNumber = UserNumbers;
            }

        } while (UserNumbers != 0);

        int TotalNumbers = numbers.Count;
        var Sum = numbers.Sum();
        var Avg = Sum / TotalNumbers;



        Console.WriteLine("");
        Console.WriteLine($"The sum is: {Sum}");
        Console.WriteLine($"The average is: {Avg}");
        Console.WriteLine($"The largest number is: {LargestNumber}");
    }

    






}