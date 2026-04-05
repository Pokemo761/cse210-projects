using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("═══════════════════════════════════════════");
        Console.WriteLine("    ONLINE ORDERING SYSTEM");
        Console.WriteLine("═══════════════════════════════════════════\n");

        // Create Order 1 - USA Customer
        Address address1 = new Address("123 Main Street", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Marcos Silva", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Wireless Mouse", "MOUSE-001", 25.99m, 2));
        order1.AddProduct(new Product("USB-C Cable", "CABLE-045", 12.50m, 3));
        order1.AddProduct(new Product("Laptop Stand", "STAND-789", 45.00m, 1));

        // Create Order 2 - International Customer
        Address address2 = new Address("456 Elm Avenue", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);
        Order order2 = new Order(customer2);
        
        order2.AddProduct(new Product("Mechanical Keyboard", "KB-2024", 89.99m, 1));
        order2.AddProduct(new Product("Monitor", "MON-4K27", 299.99m, 1));

        // Display Order 1
        Console.WriteLine("ORDER #1");
        Console.WriteLine("─────────────────────────────────────────");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        // Display Order 2
        Console.WriteLine("\nORDER #2");
        Console.WriteLine("─────────────────────────────────────────");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}\n");

        Console.WriteLine("\nProgram complete! All orders displayed.");
    }
}
