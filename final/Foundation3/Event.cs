using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    protected string GetTitle()
    {
        return _title;
    }
    protected string GetDescription()
    {
        return _description;
    }
    protected string GetDate()
    {
        return _date;
    }
    protected string GetTime()
    {
        return _time;
    }
    protected Address GetAddress()
    {
        return _address;
    }
    protected Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
}