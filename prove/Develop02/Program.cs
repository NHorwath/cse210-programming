using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int FinalInput = 0;

    do {
        Console.WriteLine("Welcome to the Journal program.");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string UserNumber = Console.ReadLine();
        FinalInput = int.Parse(UserNumber);

        if (FinalInput == 1)
        {
            PromptGenerator prompt = new PromptGenerator();
            Console.Write(">");
            

            
        }

    } while (FinalInput != 5);

    }
}

// List<string> prompts = new List<string> {"What was the best part of your day?",
//         "Write about an experience where you felt the spirit with you today:",
//         "Who was the most interesting person you interacted with today?",
//         "Write about something that happened for which you are grateful today:",
//         "If you had one thing you could do over today, what would it be?",
//         "What was the strongest emotion you felt today?",
//         "Write about an act of service you either witnessed or performed today:>",
//         "Write about something you learned today:",
//         "Write about a tender mercy you noticed today:",
//         "Write about a positive interaction you had with someone else today:",
//         "Write about something you noticed that reminded you of Jesus Christ today:",
//         "Write about something you learned about someone in your life today:",
//         "Write about an experience you had that allowed you to teach someone else today:"};

// DateTime theCurrentTime = DateTime.Now;
//         string dateText = theCurrentTime.ToShortDateString();

        //  Entry newDate = new();
        //  {
        //     newDate._date = theCurrentTime.ToShortDateString();
        //  }

        // newDate.Display();