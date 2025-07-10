public class Check : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;
    public override string GetSave()
    {
        return $"Check:{GetName()}|{GetDescription()}|{GetPoints()}|{GetIsComplete()}|{_timesCompleted}|{_targetCount}|{_bonus}";
    }
    public override void DisplayForList()
    {
        if (GetIsComplete())
        {
            string isChecked = "X";
            Console.WriteLine($"[{isChecked}] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_targetCount}");
        }
        else
        {
            string isChecked = " ";
            Console.WriteLine($"[{isChecked}] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_targetCount}");
        }
    }
    public override int RecordEvent()
    {
        if (GetIsComplete() == false)
        {
            int points = GetPoints();
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
            {
                SetIsComplete(true);
                points += _bonus;
            }
            return points;
        }
        return 0;
    }
    public Check(string name, string description, int points, bool isComplete, int timesCompleted, int targetCount, int bonus) : base(name, description, points, isComplete)
    {
        _timesCompleted = timesCompleted;
        _targetCount = targetCount;
        _bonus = bonus;
    }
}