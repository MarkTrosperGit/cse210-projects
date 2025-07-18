public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public string GetStandard()
    {
        return $"{GetTitle()}, {GetDescription()}, {GetDate()}, {GetTime()}, {GetAddress().ReturnAddress()}.";
    }
    public string GetFull()
    {
        return $"{GetStandard()}, Lecture Event, Speaking: {_speaker}, Capacity: {_capacity}.";
    }
    public string GetShort()
    {
        return $"Lecture Event, {GetTitle()}, {GetDate()}";
    }
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    
    
}