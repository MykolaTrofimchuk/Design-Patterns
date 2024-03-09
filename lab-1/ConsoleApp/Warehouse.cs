using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Warehouse
    {
        public Product[] Products { get; set; }

        public Warehouse(Product[] products)
        {
            Products = products;
        }

        public void PrintProducts()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(
                    $"Name: {product.Name}, " +
                    $"Category: {product.Category}, " +
                    $"Unit: {product.Unit}, " +
                    $"Unit Price: {product.UnitPrice}, " +
                    $"Quantity: {product.Quantity}, " +
                    $"Last Stock Date: {product.LastStockDate}");
            }
        }
    }
}
