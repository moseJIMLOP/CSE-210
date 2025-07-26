using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("123 Main St", "Springfield", "IL", "62701");
        Customer customer = new Customer("John Doe", address1);

        Product product1 = new Product("Laptop", "P001", 999.99, 1);
        Product product2 = new Product("Mouse", "P002", 25.50, 2);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(customer.GetFormattedAddress());
        Console.WriteLine($"Total Order Cost: ${order.GetTotalOrderCost():0.00}"); 
    }
}