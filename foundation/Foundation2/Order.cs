public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    
    public void SetProductList(Product product)
    {
        _productList.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public int CalculateTotalCost()
    {
        int totalCost = 0;
        foreach (Product product in _productList)
        {
            totalCost += product.CalculateCost();
        }
        if (_customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        List<String> packingLabel = new List<String>();
        foreach (Product product in _productList)
        {
            packingLabel.Add($"{product.GetName()} {product.GetID()}");
        }
        string stringPackingLabel = String.Join(", ", packingLabel);
        return stringPackingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}, {_customer.GetAddress()}";
    }
}