// To add extra functionality to my program, I made it so that the user gets to choose which scripture to view and memorize.

using System;
using System.Net.Quic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = null;
        string input = "";
        while (input != "1" && input != "2")
        {
            Console.Write("Press 1 to view John 3:16 or 2 to view Proverbs 3:5-6 ");
            input = Console.ReadLine();
            Console.WriteLine();
        }

        if (input == "1")
        {
            scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        }
        else
        {
            scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        }
        string command = "";
        while (command != "quit" && scripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            command = Console.ReadLine();
            scripture.HideRandomWords();
        }
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}