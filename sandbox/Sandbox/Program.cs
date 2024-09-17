using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }

    }
    
}
