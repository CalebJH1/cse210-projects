public class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;


    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    
    public int CalculateCost()
    {
        int cost;
        cost = _price * _quantity;
        return cost;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _id;
    }
}