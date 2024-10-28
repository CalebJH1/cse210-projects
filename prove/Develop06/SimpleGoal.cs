public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }


    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string shortName = GetName();
        return shortName;
    }

    public override int GetBonus()
    {
        return 0;
    }

    public override int GetAmountCompleted()
    {
        return 0;
    }

    public override int GetTarget()
    {
        return 0;
    }
}