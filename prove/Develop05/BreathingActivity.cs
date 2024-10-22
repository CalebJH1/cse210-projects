using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        int timeSpent = 0;
        Console.WriteLine("Get ready...");
        
        ShowSpinner(3);

        int duration = GetDuration();
        while (duration > 0)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            duration -= 4;
            timeSpent += 4;
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            duration -= 6;
            timeSpent += 6;
            Console.WriteLine();
        }
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine();
        DisplayEndingMessage(timeSpent);
        ShowSpinner(3);
        Console.Clear();
    }
}