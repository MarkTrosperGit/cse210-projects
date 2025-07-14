public class Gathering : Event
{
    private string _forecast;
    public Gathering(string title, string desc, DateTime date, DateTime time, Address address, string forecast) : base(title, desc, date, time, address)
    {
        _forecast = forecast;
    }
    
    
}