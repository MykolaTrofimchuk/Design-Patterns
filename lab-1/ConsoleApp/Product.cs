using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // Categories:
    public enum ProductCategory
    {
        Electronics,
        Clothing,
        Groceries,
        Books,
        Beauty
    }

    public class Product
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime LastStockDate { get; set; }

        public ProductCategory Category { get; set; }

        public void DecreasePrice(decimal amount)
        {
            UnitPrice -= amount;
        }
    }
}
