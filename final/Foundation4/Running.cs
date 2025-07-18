public class Running : Activity
{
    private float _distance;
    public Running(string date, int length, float distance) : base(date, length) {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (double)(_distance/GetLength())*60;
    }
    public override double GetPace()
    {
        return (double)GetLength() / _distance;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min)-\nDistance {GetDistance()} miles,\nSpeed {GetSpeed()} kph,\nPace: {GetPace()} min per km";
    }
}