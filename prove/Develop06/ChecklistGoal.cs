public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (IsComplete() == false)
        {
            _amountCompleted++;
            if (_target - _amountCompleted == 1)
            {
                SetPoints(_bonus);
            }
        }  
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
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

    public override string GetDetailsString()
    {
        return $"{GetName()} ({GetDescription()}) -- {_amountCompleted}/{_target} completed ";
    }

    public override int GetBonus()
    {
        return _bonus;
    }

    public override int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override int GetTarget()
    {
        return _target;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

}