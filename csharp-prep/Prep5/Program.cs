using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int Square = SquareNumber(UserNumber);

        DisplayResult(UserName, Square);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();
        return Name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string UserInput = Console.ReadLine();
        int number = int.Parse(UserInput);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square; 
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine("");
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}