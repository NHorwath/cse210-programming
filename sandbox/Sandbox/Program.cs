using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        PromptGenerator prompt = new();
        {
            prompt._prompts = "Write about something you learned today:";
        }

        Entry date1 = new();
        {
            date1._date = theCurrentTime.ToShortDateString();
            date1._entryText = prompt._prompts;
        }

        date1.Display();
    }
    
}
