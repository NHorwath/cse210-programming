using System;

class Program
{
    static void Main(string[] args)
    {  
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine($"Guess the Magic number: ");
        int UserNumber = -1;
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
            }

            else if (UserNumber > number)
            {
                Console.WriteLine("Lower");
            }
        } while (UserNumber != number);

        Console.Write("You guessed it! ");

        if (UserTries == 1)
        {
            Console.WriteLine($"You took {UserTries} try!");
        }
        else
        {
            Console.WriteLine($"You took {UserTries} tries!");
        }
    }
}