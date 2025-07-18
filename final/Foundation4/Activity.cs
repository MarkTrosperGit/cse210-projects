public abstract class Activity
{
    private string _date;
    private int _length;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    protected string GetDate()
    {
        return _date;
    }
    protected int GetLength()
    {
        return _length;
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
    public virtual string GetSummary()
    {
        return "";
    }
}