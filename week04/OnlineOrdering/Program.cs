using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (USA)

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P1001", 850, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P1003", 40, 1));

        // Second Order (Outside USA)

        Address address2 = new Address(
            "15 Herbert Macaulay Way",
            "Abuja",
            "FCT",
            "Nigeria");

        Customer customer2 = new Customer("Gloria John", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "P2001", 180, 2));
        order2.AddProduct(new Product("USB Drive", "P2002", 15, 4));

        // Display First Order

        Console.WriteLine("===== ORDER 1 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n---------------------------------\n");

        // Display Second Order

        Console.WriteLine("===== ORDER 2 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order2.CalculateTotalCost()}");
    }
}