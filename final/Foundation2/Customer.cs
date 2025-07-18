using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;
    public bool InUS()
    {
        return _address.InUS();
    }
    public string GetNameAndAddress()
    {
        return $"{_name} - {_address.ReturnAddress()}";
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}