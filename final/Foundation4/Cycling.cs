public class Cycling : Activity
{
    private float _speed;
    public Cycling(string date, int length, float speed) : base(date, length) {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * GetLength();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min)-\nDistance {GetDistance()} miles,\nSpeed {GetSpeed()} kph,\nPace: {GetPace()} min per km";
    }
}