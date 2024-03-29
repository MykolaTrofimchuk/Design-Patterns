﻿using System;
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
            Console.WriteLine($"{wholePart}.{pennies} {currency}/s");
        }

        public void Subtract(Money amount)
        {
            if (checkCurrency(amount.Currency)) 
            {
                wholePart -= amount.WholePart;
                pennies -= amount.Pennies;

                if (pennies < 0)
                {
                    pennies += 100;
                    wholePart--;
                }
            }
            else
            {
                Console.WriteLine("Error: Currency mismatch. Cannot subtract money with different currencies.");
            }
        }

        private bool checkCurrency(string otherCurrency)
        {
            return currency == otherCurrency; 
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
