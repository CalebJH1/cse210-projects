// To exceed the expectations, I've added a couple of functions to the base class to allow the program to keep track of and display a log.

using System;
using System.Diagnostics;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<string> log = new List<string>();
        string activity = "0";
        while (activity != "4")
        {
            Console.WriteLine("Pick a mindfulness activity:  ");
            Console.WriteLine("    1. Breathing");
            Console.WriteLine("    2. Reflecting");
            Console.WriteLine("    3. Listing");
            Console.WriteLine("    4. Exit");
            Console.Write("Type in a number: ");

            activity = Console.ReadLine();
            if (activity == "1")
            {
                Console.Clear();
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathingActivity = new BreathingActivity(name, description);
                breathingActivity.DisplayStartingMessage();
                string durationString = Console.ReadLine();
                int duration = int.Parse(durationString);
                breathingActivity.SetDuration(duration);
                Console.Clear();
                breathingActivity.Run();
                log = breathingActivity.UpdateLog(log, duration);
                Console.WriteLine("Would you like to show your log so far? (Type 'y' for yes) ");
                string response = Console.ReadLine();
                if (response == "y")
                {
                    breathingActivity.DisplayLog(log);
                    breathingActivity.ShowSpinner(5);
                }
                Console.Clear();
            }

            if (activity == "2")
            {
                Console.Clear();
                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflectingActivity = new ReflectingActivity(name, description);
                reflectingActivity.DisplayStartingMessage();
                string durationString = Console.ReadLine();
                int duration = int.Parse(durationString);
                reflectingActivity.SetDuration(duration);
                Console.Clear();
                reflectingActivity.Run();
                log = reflectingActivity.UpdateLog(log, duration);
                Console.WriteLine("Would you like to show your log so far? (Type 'y' for yes) ");
                string response = Console.ReadLine();
                if (response == "y")
                {
                    reflectingActivity.DisplayLog(log);
                    reflectingActivity.ShowSpinner(5);
                    Console.Clear();
                }
            }

            if (activity == "3")
            {
                Console.Clear();
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listingActivity = new ListingActivity(name, description);
                listingActivity.DisplayStartingMessage();
                string durationString = Console.ReadLine();
                int duration = int.Parse(durationString);
                listingActivity.SetDuration(duration);
                Console.Clear();
                listingActivity.Run();
                log = listingActivity.UpdateLog(log, duration);
                Console.WriteLine("Would you like to show your log so far? (Type 'y' for yes) ");
                string response = Console.ReadLine();
                if (response == "y")
                {
                    listingActivity.DisplayLog(log);
                    listingActivity.ShowSpinner(5);
                    Console.Clear();
                }
            }
        }
    }
}
        