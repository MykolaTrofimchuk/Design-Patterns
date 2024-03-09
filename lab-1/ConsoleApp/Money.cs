using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // Single Responsibility Principle (SOLID)

    public class Money
    {
        private int wholePart;
        private int pennies;
        private string currency;

        public Money(int wholePart, int pennies, string currency)
        {
            this.wholePart = wholePart;
            this.pennies = pennies;
            this.currency = currency;
        }

        public int WholePart
        {
            get { return wholePart; }
            set { wholePart = value; }
        }

        public int Pennies
        {
            get { return pennies; }
            set { pennies = value; }
        }

        public string Currency
        {
            get { return currency; }
            private set { currency = value; }
        }

        public void PrintAmount()
        {
            Console.WriteLine($"Total amount: {wholePart}.{pennies} {currency}/s");
        }
    }

    // A specific currency class for the dollar
    public class Dollar : Money
    {
        public Dollar(int wholePart, int cents) : base(wholePart, cents, "Dollar")
        {
        }
    }

    // A specific currency class for the euro
    public class Euro : Money
    {
        public Euro(int wholePart, int cents) : base(wholePart, cents, "Euro")
        {
        }
    }


    // A specific currency class for the UAN
    public class UAN : Money
    {
        public UAN(int wholePart, int cents) : base(wholePart, cents, "UAN")
        {
        }
    }
}
