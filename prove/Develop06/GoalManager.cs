// To show creativity and exceed core requirements, I've implemented a leveling up system into my program. In the beginning of the program, 
// the user is asked the number of points needed for each level up.

using System.Diagnostics;
using System.Runtime;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Net;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;
    private int _scoreRequired;
    private int _totalScoreRequired;
    
    public void Start()
    {
        string option = "";
        SetScoreRequired(); 
        while (option != "6")
        {
            string response = "";
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            Console.Write("Select a choice from the menu: ");

            option = Console.ReadLine();

            if (option == "1")
            {
                CreateGoal();
            }

            if (option == "2")
            {
                ListGoalDetails();
            }

            if (option == "3")
            {
                Console.WriteLine();
                Console.Write("Are you sure you want to overwrite your current save? (type 'y' for yes) ");
                response = Console.ReadLine();
                if (response == "y")
                {
                    SaveGoals();
                }
            }

            if (option == "4")
            {
                if (_goals.Count > 0)
                {
                    Console.WriteLine();
                    Console.Write("You currently have at least one goal in your list. Would you like to overwrite it? (type 'y' for yes) ");
                    response = Console.ReadLine();
                    if (response == "y")
                    {
                        LoadGoals();
                    }
                }

                else
                {
                    LoadGoals();
                }

            }

            if (option == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your rank is level {_level}.");
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine();
        int goalNumber = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal.GetStringRepresentation()}");
            goalNumber++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine();
        int goalNumber = 1;

        foreach (Goal goal in _goals)
        {
            Console.Write($"{goalNumber}. [");
            if (goal.IsComplete())
            {
                Console.Write("X");
            }
            Console.WriteLine($"] {goal.GetDetailsString()}");
            goalNumber++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("What type of goal is it?");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Type in a number: ");

        string goalType = Console.ReadLine();
        while (goalType != "1" && goalType != "2" && goalType != "3")
        {
            Console.WriteLine();
            Console.Write("Type in 1, 2, or 3: ");
            goalType = Console.ReadLine();
        }

        if (goalType == "1")
        {
            Console.WriteLine();
            Console.Write("What is your goal? ");
            string name = Console.ReadLine();
            Console.Write("Please provide a brief description: ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal worth? ");
            string stringPoints = Console.ReadLine();
            int points = CheckUserInput(stringPoints);
            stringPoints = points.ToString();
            SimpleGoal simpleGoal = new SimpleGoal(name, description, stringPoints);
            _goals.Add(simpleGoal);
        }

        if (goalType == "2")
        {
            Console.WriteLine();
            Console.Write("What is your goal? ");
            string name = Console.ReadLine();
            Console.Write("Please provide a brief description: ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal worth? ");
            string stringPoints = Console.ReadLine();
            int points = CheckUserInput(stringPoints);
            stringPoints = points.ToString();
            EternalGoal eternalGoal = new EternalGoal(name, description, stringPoints);
            _goals.Add(eternalGoal);
        }

        if (goalType == "3")
        {
            Console.WriteLine();
            Console.Write("What is your goal? ");
            string name = Console.ReadLine();
            Console.Write("Please provide a brief description: ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal worth? ");
            string stringPoints = Console.ReadLine();
            int points = CheckUserInput(stringPoints);
            stringPoints = points.ToString();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string stringTarget = Console.ReadLine();
            int target = CheckUserInput(stringTarget);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string stringBonus = Console.ReadLine();
            int bonus = CheckUserInput(stringBonus);
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, stringPoints, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        if (_goals.Count == 0)
        {
            Console.WriteLine("Your goal list is empty.");
        }

        else
        {
            Console.WriteLine("Awesome! Which of these goals did you complete?");
            ListGoalNames();
            Console.WriteLine();
            Console.Write("Type in a number: ");
            while (true)
            {
                try
                {
                    string stringIndex = Console.ReadLine();
                    int index = int.Parse(stringIndex);
                    Goal goal = _goals[index - 1];
                    string stringPoints = goal.GetPoints();
                    int points = int.Parse(stringPoints);
                    if (goal.IsComplete() == false)
                    {
                        Console.WriteLine($"Congratulations! You've earned {stringPoints} points!");
                        _score += points;
                        if (_score >= _totalScoreRequired)
                        {
                            LevelUp();
                        }
                    }

                    else
                    {
                        Console.WriteLine("This goal has already been completed.");
                    }

                    goal.RecordEvent();
                    break;
                }

                catch
                {
                    Console.Write("Please type in a number that is in this list: ");
                }
            }
        }
    }

    public void SaveGoals()
    {
        string fileName = "goals.txt";
        File.WriteAllText(fileName, string.Empty);
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_level},{_totalScoreRequired}");
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                if (goal.GetType() == typeof(SimpleGoal))
                {
                    outputFile.Write($"{goal.GetType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.IsComplete()}\n");
                }

                if (goal.GetType() == typeof(EternalGoal))
                {
                    outputFile.Write($"{goal.GetType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()}\n");
                }
                
                if (goal.GetType() == typeof(ChecklistGoal))
                {
                    outputFile.Write($"{goal.GetType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.GetBonus()},{goal.GetTarget()},{goal.GetAmountCompleted()}\n");
                }

            }
        }
        _goals.Clear();
        _score = 0;
        _level = 0;
        Console.WriteLine();
        SetScoreRequired();
    }

    public void LoadGoals()
    {
        _goals.Clear();
        string fileName = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        string levelInfo = lines[0];
        string[] levelInfoList = levelInfo.Split(",");

        string stringLevel = levelInfoList[0];
        string stringTotalScoreRequired = levelInfoList[1];
        string stringScore = lines[1];

        _level = int.Parse(stringLevel);
        _totalScoreRequired = int.Parse(stringTotalScoreRequired);
        _score = int.Parse(stringScore);

        _scoreRequired = _totalScoreRequired / (_level + 1);

        int lineNumber = 0;
        foreach (string line in lines)
        {
            if (lineNumber >= 2)
            {
                string[] parts = line.Split(",");
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];

                if (goalType == "SimpleGoal")
                {
                    string isComplete = parts[4];
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                    if (isComplete == "True")
                    {
                        simpleGoal.RecordEvent();
                    }
                }

                if (goalType == "ChecklistGoal")
                {
                    string stringBonus = parts[4];
                    string stringTarget = parts[5];
                    string stringAmountCompleted = parts[6];
                    
                    int bonus = int.Parse(stringBonus);
                    int target = int.Parse(stringTarget);
                    int amountCompleted = int.Parse(stringAmountCompleted);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);
                    checklistGoal.SetAmountCompleted(amountCompleted);
                }

                if (goalType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
            }
            lineNumber++;
        }
    }

    public void LevelUp()
    {
        int levelUp = 0;
        while (_totalScoreRequired <= _score)
        {
            _level++;
            _totalScoreRequired += _scoreRequired;
            levelUp++;
        }
        Console.WriteLine();
        Console.WriteLine($"You leveled up {levelUp} time(s)!");
    }

    private void SetScoreRequired()
    {
        Console.Write("How many points to level up? (This won't count if you're going to load a file) ");
        string stringRequiredXP = Console.ReadLine();
        _scoreRequired = CheckUserInput(stringRequiredXP);
        _totalScoreRequired = _scoreRequired;
    }

    private int CheckUserInput(string userInput)
    {
        int num = 0;
        while (num <= 0)
        {
            try
            {
                num = int.Parse(userInput);

                if (num <= 0)
                {
                    Console.Write("Needs to be bigger: ");
                    userInput = Console.ReadLine();
                }
            }

            catch
            {
                Console.Write("Please type in a number: ");
                userInput = Console.ReadLine();
            }
        }
        return num;
    }
}