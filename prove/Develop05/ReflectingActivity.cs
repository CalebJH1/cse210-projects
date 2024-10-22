using System.Globalization;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = ["Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."];

        _questions = ["Why was this experience meaningful to you?",
                      "Have you ever done anything like this before?",
                      "How did you get started?",
                      "How did you feel when it was complete?",
                      "What made this time different than other times when you were not as successful?",
                      "What is your favorite thing about this experience?",
                      "What could you learn from this experience that applies to other situations?",
                      "What did you learn about yourself through this experience?",
                      "How can you keep this experience in mind in the future?"];
    }

    public void Run()
    {
        int timeSpent = 0;
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        Console.WriteLine();
        Console.WriteLine("If you're ready, hit enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Questions will appear one by one. Make sure you ponder them carefully.");
        Console.Write("Starting in ");
        ShowCountDown(5);
        Console.Clear();
        int duration = GetDuration();
        while (duration > 0)
        {
            string question = GetRandomQuestion();
            DisplayQuestions(question);
            ShowSpinner(10);
            Console.WriteLine();
            duration -= 10;
            timeSpent += 10;
        }
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine();
        DisplayEndingMessage(timeSpent);
        ShowSpinner(3);
        Console.Clear();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string randomQuestion = _questions[index];
        return randomQuestion;
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine($" --- {prompt} ---");
    }

    private void DisplayQuestions(string question)
    {
        Console.Write($"> {question} ");
    }
}