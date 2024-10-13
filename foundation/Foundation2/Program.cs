using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();

        Customer customer1 = new Customer("Noah");
        order1.SetCustomer(customer1);

        Address address1 = new Address("Gresham", "Oregon", "USA");
        customer1.SetAddress(address1);

        Product product1a = new Product("Dog Food", 75293, 5, 2);
        order1.SetProductList(product1a);

        Product product1b = new Product("Milk", 89245, 4, 1);
        order1.SetProductList(product1b);

        Product product1c = new Product("Candy", 83325, 2, 5);
        order1.SetProductList(product1c);

        Product product1d = new Product("Pizza", 38294, 10, 1);
        order1.SetProductList(product1d);

        Console.WriteLine($"{order1.CalculateTotalCost()} dollars");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();

        Order order2 = new Order();

        Customer customer2 = new Customer("Jorge");
        order2.SetCustomer(customer2);
        
        Address address2 = new Address("Mexico City", "Mexico");
        customer2.SetAddress(address2);

        Product product2a = new Product("Tortillas", 12468, 5, 3);
        order2.SetProductList(product2a);

        Product product2b = new Product("Meat", 47359, 9, 1);
        order2.SetProductList(product2b);

        Product product2c = new Product("Seasoning", 23984, 5, 2);
        order2.SetProductList(product2c);

        Product product2d = new Product("Cheese", 38294, 3, 2);
        order2.SetProductList(product2d);

        Console.WriteLine($"{order2.CalculateTotalCost()} dollars");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}