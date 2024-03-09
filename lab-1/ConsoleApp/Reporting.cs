using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        // DRY (Don't Repeat Yourself): Методи RegisterIncoming та RegisterOutgoing використовуються для збільшення та зменшення кількості товарів, відповідно. 

        public void RegisterIncoming(Product product, int quantity)
        {
            product.Quantity += quantity;
            product.LastStockDate = DateTime.Now;
            Console.WriteLine($"Registered incoming for {quantity} {product.Unit} of {product.Name} (Registered at {product.LastStockDate})");
        }

        public void RegisterOutgoing(Product product, int quantity)
        {
            if (product.Quantity >= quantity)
            {
                product.Quantity -= quantity;
                Console.WriteLine($"Registered outgoing for {quantity} {product.Unit} of {product.Name}");
            }
            else
            {
                Console.WriteLine($"Not enough {product.Name} in stock to register outgoing.");
            }
        }

        public void InventoryReport()
        {
            Console.WriteLine("Inventory Report:");

            foreach (var product in warehouse.Products)
            {
                Console.WriteLine($"Name: {product.Name}, Quantity: {product.Quantity} {product.Unit}");
            }
        }
    }
}
