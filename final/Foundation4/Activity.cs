abstract class Activity
{
    private DateTime _date;
    private int _length;
    protected Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }
    protected virtual double GetDistance(int laps)
    {
        return laps * 50 / 0.62;
    }
    protected virtual double GetSpeed(double distance, int minutes)
    {
        return (double)(distance / minutes) * 60;
    }
    protected virtual double GetPace(double speed)
    {
        return 60 / speed;
    }
    protected virtual string GetSummary(DateTime date, int length, double distance, double speed)
    {
        return "";
    }
}