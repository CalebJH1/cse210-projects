using System.Runtime.CompilerServices;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage(int timeSpent)
    {
        Console.WriteLine($"You have completed another {timeSpent} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        for (int i = 0; i < seconds; i++)
        {
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
        }
        foreach (string animationString in animationStrings)
        {
            Console.Write(animationString);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int j = seconds; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                seconds--;
            }
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public List<string> UpdateLog(List<string> log, int duration)
    {
        log.Add($"{_name}: {duration} seconds");
        return log;
    }

    public void DisplayLog(List<string> log)
    {
        foreach (string entry in log)
        {
            Console.WriteLine(entry);
        }
    }
}