using ConsoleApp;
using Microsoft.Win32;

internal class Program
{
    private static void Main(string[] args)
    {
        Dollar d = new Dollar(1000, 10);
        d.PrintAmount();

        Product product = new Product
        {
            Name = "Smartphone",
            Unit = "pcs",
            UnitPrice = d,
            Quantity = 8,
            LastStockDate = DateTime.Now,
            Category = ProductCategory.Electronics
        };

        // Product`s info
        Console.WriteLine("Product Information:");
        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Category: {product.Category}");
        Console.WriteLine($"Unit Price: {product.UnitPrice.WholePart}.{product.UnitPrice.Pennies} {product.UnitPrice.Currency}");
        Console.WriteLine($"Quantity: {product.Quantity} {product.Unit}");
        Console.WriteLine($"Last Stock Date: {product.LastStockDate}");

        // Substract price
        Dollar discount = new Dollar(200, 25); // Sale $200.25
        product.DecreasePrice(discount);

        // Check product`s price info after substracting
        Console.WriteLine("\nProduct Information after discount:");
        Console.WriteLine($"Unit Price: {product.UnitPrice.WholePart}.{product.UnitPrice.Pennies} {product.UnitPrice.Currency}/s\n");

        // Check substracting price with another currency // Error
        Euro discountEr = new Euro(200, 25);
        Console.WriteLine("\nProduct Information after FALSE discount:");
        product.DecreasePrice(discountEr);
        Console.WriteLine("\n\n");



        // Check another classes work
        Product product2 = new Product
        {
            Name = "T-Shirt",
            Unit = "pcs",
            UnitPrice = new UAN(450, 50),
            Quantity = 100,
            LastStockDate = DateTime.Now,
            Category = ProductCategory.Clothing
        };

        Warehouse warehouse = new Warehouse(new Product[] { product, product2 });
        Reporting reporting = new Reporting(warehouse);

        // checking with True values:
        reporting.RegisterIncoming(product, 20); // ok
        reporting.RegisterOutgoing(product2, 10); // ok
        reporting.InventoryReport();

        Console.WriteLine("\n");

        // checking with False Values of quantity at Register Outgoing:
        reporting.RegisterOutgoing(product2, 110); // Not enough T - Shirt in stock to register outgoing.
        reporting.InventoryReport();
    }
}