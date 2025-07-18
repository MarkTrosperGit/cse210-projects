public class Gathering : Event
{
    private string _forecast;
    public Gathering(string title, string desc, string date, string time, Address address, string forecast) : base(title, desc, date, time, address)
    {
        _forecast = forecast;
    }
    public string GetStandard()
    {
        return $"{GetTitle()}, {GetDescription()}, {GetDate()}, {GetTime()}, {GetAddress().ReturnAddress()}.";
    }
    public string GetFull()
    {
        return $"{GetStandard()}, Gathering Event.";
    }
    public string GetShort()
    {
        return $"Gathering Event, {GetTitle()}, {GetDate()}";
    }
    
}