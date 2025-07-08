public class Check : Goals
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;
    public override void getSave()
    {
        Console.WriteLine("hi");
    }
    public override void recordEvent()
    {
        throw new NotImplementedException();
    }
    public Check(string name, string description, int score, bool isComplete, int timesCompleted, int targetCount, int bonus) : base(name, description, score, isComplete)
    {
        _timesCompleted = timesCompleted;
        _targetCount = targetCount;
        _bonus = bonus;
    }
}