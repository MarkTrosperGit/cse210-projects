public class Reception : Event
{
    private string _rsvp;
    public Reception(string title, string desc, DateTime date, DateTime time, Address address) : base(title, desc, date, time, address)
    {
        _rsvp = "Please RSVP at hello@places.com";
    }
    
    
}