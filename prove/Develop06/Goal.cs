using System.Threading.Channels;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;


    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();

    public abstract int GetBonus();

    public abstract int GetAmountCompleted();

    public abstract int GetTarget();

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public void SetPoints(int bonus)
    {
        int points = int.Parse(_points);
        points += bonus;
        _points = points.ToString();
    }
}