using System;
using System.IO.Enumeration;
using System.Net;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator thePrompt = new PromptGenerator();

        thePrompt._prompts.Add("Who was the most interesting person I interacted with today?");
        thePrompt._prompts.Add("What was the best part of my day?");
        thePrompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        thePrompt._prompts.Add("What was the strongest emotion I felt today?");
        thePrompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        
        string response = "";

        while (response != "5")
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            response = Console.ReadLine();

            if (response == "1")
            {
                Console.WriteLine();
                Entry newEntry = new Entry();
                newEntry._promptText = thePrompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                theJournal.AddEntry(newEntry);
                Console.WriteLine();
            }

            if (response == "2")
            {
                Console.WriteLine();
                theJournal.DisplayAll();
            }

            if (response == "3")
            {
                Console.WriteLine();
                Console.Write("Which file would you like to open? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }

            if (response == "4")
            {
                Console.WriteLine();
                Console.Write("Which file would you like to save it to? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
                Console.WriteLine();
            }
        }
    }
}