using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name)
    {
        _name = name;
    }


    public void SetAddress(Address address)
    {
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}