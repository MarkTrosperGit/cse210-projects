using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;
    protected string GetStandard()
    {
        return "";
    }
    protected string GetFull()
    {
        return "";
    }
    protected string GetDesc()
    {
        return "";
    }
    protected Event(string title, string desc, DateTime date, DateTime time, Address address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }
}