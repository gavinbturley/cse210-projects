using System;

class Program
{
    static void Main(string[] args)
    {
        //First test order
        Address address1 = new Address("123 Elm St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", 1001, 999.99, 1));
        order1.AddProduct(new Product("Mouse", 1002, 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        // Second test order
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Johnson", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", 2001, 599.99, 1));
        order2.AddProduct(new Product("Charger", 2002, 19.99, 2));
        order2.AddProduct(new Product("Case", 2003, 14.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");

    }
}