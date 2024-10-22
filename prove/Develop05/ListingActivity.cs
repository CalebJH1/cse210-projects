public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();


    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = ["Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you've helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"];
    }

    public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine("Make a list of as many responses as you can answering the following question:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("Starting in ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> list = GetListFromUser();
        _count = list.Count;
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine();
        int duration = GetDuration();
        DisplayEndingMessage(duration);
        ShowSpinner(3);
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public List<string> GetListFromUser()
    {
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        List<string> responses = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }
        return responses;
    }
}