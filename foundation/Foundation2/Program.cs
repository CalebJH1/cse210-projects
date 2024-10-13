using System;

class Program
{
    static void Main(string[] args)
    {
        Order orderA = new Order();

        Customer customerA = new Customer("Noah");
        orderA.SetCustomer(customerA);

        Address addressA = new Address("Gresham", "Oregon", "USA");
        customerA.SetAddress(addressA);

        Product productA1 = new Product("Dog Food", 75293, 5, 2);
        orderA.SetProductList(productA1);

        Product productA2 = new Product("Milk", 89245, 4, 1);
        orderA.SetProductList(productA2);

        Product productA3 = new Product("Candy", 83325, 2, 5);
        orderA.SetProductList(productA3);

        Product productA4 = new Product("Pizza", 38294, 10, 1);
        orderA.SetProductList(productA4);

        Console.WriteLine($"{orderA.CalculateTotalCost()} dollars");
        Console.WriteLine(orderA.GetPackingLabel());
        Console.WriteLine(orderA.GetShippingLabel());

        Console.WriteLine();

        Order orderB = new Order();

        Customer customerB = new Customer("Jorge");
        orderB.SetCustomer(customerB);
        
        Address addressB = new Address("Mexico City", "Mexico");
        customerB.SetAddress(addressB);

        Product productB1 = new Product("Tortillas", 12468, 5, 3);
        orderB.SetProductList(productB1);

        Product productB2 = new Product("Meat", 47359, 9, 1);
        orderB.SetProductList(productB2);

        Product productB3 = new Product("Seasoning", 23984, 5, 2);
        orderB.SetProductList(productB3);

        Product productB4 = new Product("Cheese", 38294, 3, 2);
        orderB.SetProductList(productB4);

        Console.WriteLine($"{orderB.CalculateTotalCost()} dollars");
        Console.WriteLine(orderB.GetPackingLabel());
        Console.WriteLine(orderB.GetShippingLabel());
    }
}