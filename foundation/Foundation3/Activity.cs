public class Activity
{
    private string _date;
    protected int _duration;


    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_duration} min): Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)}, Pace: {Math.Round(GetPace(), 2)}";
    }
}