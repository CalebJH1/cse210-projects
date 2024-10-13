public class Address
{
    private string _city;
    private string _state;
    private string _country;


    public Address(string city, string state, string country)
    {
        _city = city;
        _state = state;
        _country = country;
    }

    public Address(string city, string country)
    {
        _city = city;
        _country = country;
        _state = "";
    }

    public bool IsInUSA()
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

    public string GetAddress()
    {
        if (_state == "")
        {
            return $"{_city}, {_country}";
        }
        else
        {
            return $"{_city}, {_state}, {_country}";
        }

    }
}