public class Address
{
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;
    public bool InUS()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string ReturnAddress()
    {
        return $"{_streetName}, {_city}, {_state}, {_country}";
    }
    public Address(string streetName, string city, string state, string country)
    {
        _streetName = streetName;
        _city = city;
        _state = state;
        _country = country;
    }
}