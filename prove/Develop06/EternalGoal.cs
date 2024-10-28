public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
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