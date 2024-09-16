using System;

class Program
{
    static void Main(string[] args)
    {  
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine($"Guess the number: {number}");
        int UserNumber = 0;
        int UserTries = 0;

        do
        {
            Console.Write("What is your number? ");
            string UserInput = Console.ReadLine();
            UserNumber = int.Parse(UserInput);
            UserTries++;



            if (UserNumber < number)
            {
                Console.WriteLine("Higher");
                Console.WriteLine("");
            }

            else if (UserNumber > number)
            {
                Console.WriteLine("Lower");
                Console.WriteLine("");
            }
        } while (UserNumber != number);

        Console.WriteLine("You guessed it!");

        if (UserTries == 1)
        {
            Console.WriteLine($"You took {UserTries} try!");
        }
        else
        {
            Console.WriteLine($"You took {UserTries} tries!");
            Console.WriteLine("");
        }
    }
}