using System;

class Program
{   
    static void Main(string[] args)
    {
        // Create at least two orders with a 2-3 products each
        
        // --------------- ORDER 1 ----------------------
        // Create instances of each needed custom class
        var order1 = new Order();
        var product1 = new Product("Lavender Soap", "A123", 2.50, 1);
        var product2 = new Product("Rose Petal Bath Bomb", "B456", 4.99, 2);
        var address1 = new Address("130 Robin Lane", "Provo", "Utah", "USA");
        address1.DisplayAddress();
        var customer1 = new Customer("Julie Smith", address1);
        order1.SetCustomerDetails(customer1);

        // Create a new list to store products for the order and set it to the _products list in the Order class
        var order1Products = new List<Product>();
        order1.SetProductsList(order1Products);
        // Add new products to the new list
        order1Products.Add(product1);
        order1Products.Add(product2);
        
        // Call the methods to get the packing label, the shipping label, and the total price of the order
        string o1p1PackingDetails = order1.CreatePackingDetails(product1.GetProductID(), product1.GetProductName());
        string o1p2PackingDetails = order1.CreatePackingDetails(product2.GetProductID(), product2.GetProductName());
        string o1PackingLabel = $"{o1p1PackingDetails}\n{o1p2PackingDetails}"; //<---add packing details for all products here
        string o1ShippingLabel = order1.CreateShippingLabel();
        double o1Total = order1.CalculateTotal();
        
        // Display the results of these methods
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Order 1, Packing Label:\n{o1PackingLabel}");
        Console.WriteLine();
        Console.WriteLine($"Order 1, Shipping Label:\n{o1ShippingLabel}");
        Console.WriteLine();
        Console.WriteLine($"Order 1, Total: ${o1Total}");


        // --------------- ORDER 2 ----------------------
        // Create instances of each needed custom class
        var order2 = new Order();
        var product3 = new Product("Beard Oil", "C789", 8.50, 1);
        var product4 = new Product("Men's 4-blade Razor", "D101", 7, 3);
        var product5 = new Product("Sandalwood-scented Lotion", "E112", 4, 2);
        var address2 = new Address("150 Main Street", "Quebec City", "Quebec", "Canada");
        address2.DisplayAddress();
        var customer2 = new Customer("Richard Richardson", address2);
        order2.SetCustomerDetails(customer2);

        // Create a new list to store products for the order
        var order2Products = new List<Product>();
        order2.SetProductsList(order2Products);
        // Add new products to the new list
        order2Products.Add(product3);
        order2Products.Add(product4);
        order2Products.Add(product5);
        
        // Call the methods to get the packing label, the shipping label, and the total price of the order
        string o2p3PackingDetails = order2.CreatePackingDetails(product3.GetProductID(), product3.GetProductName());
        string o2p4PackingDetails = order2.CreatePackingDetails(product4.GetProductID(), product4.GetProductName());
        string o2p5PackingDetails = order2.CreatePackingDetails(product5.GetProductID(), product5.GetProductName());
        string o2PackingLabel = $"{o2p3PackingDetails}\n{o2p4PackingDetails}\n{o2p5PackingDetails}"; //<---add packing details for other products here
        string o2ShippingLabel = order2.CreateShippingLabel();
        double o2Total = order2.CalculateTotal();
        
        // Display the results of these methods
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Order 2, Packing Label:\n{o2PackingLabel}");
        Console.WriteLine();
        Console.WriteLine($"Order 2, Shipping Label:\n{o2ShippingLabel}");
        Console.WriteLine();
        Console.WriteLine($"Order 2, Total: ${o2Total}");
    }
}