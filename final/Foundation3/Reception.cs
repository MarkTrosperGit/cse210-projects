public class Reception : Event
{
    private string _rsvp;
    public Reception(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _rsvp = "Please RSVP at hello@places.com";
    }
    public string GetStandard()
    {
        return $"{GetTitle()}, {GetDescription()}, {GetDate()}, {GetTime()}, {GetAddress().ReturnAddress()}.";
    }
    public string GetFull()
    {
        return $"{GetStandard()}, Reception Event, {_rsvp}.";
    }
    public string GetShort()
    {
        return $"Reception Event, {GetTitle()}, {GetDate()}";
    }
}