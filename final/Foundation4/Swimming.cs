public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int length, int laps) : base(date, length) {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (double)_laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return (double)GetDistance()/GetLength();
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min)-\nDistance {GetDistance()} miles,\nSpeed {GetSpeed()} kph,\nPace: {GetPace()} min per km";
    }
}