using ConsoleApp;

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
            Quantity = 10,
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
        Money discount = new Money(200, 25, "USD"); // Sale $200.25
        product.DecreasePrice(discount);

        // Check product`s info after substracting
        Console.WriteLine("\nProduct Information after discount:");
        Console.WriteLine($"Unit Price: {product.UnitPrice.WholePart}.{product.UnitPrice.Pennies} {product.UnitPrice.Currency}/s");
    }
}