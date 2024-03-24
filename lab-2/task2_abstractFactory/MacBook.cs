using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_abstractFactory
{
    // Конкретний клас макбука
    public class MacBook : Laptop
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a MacBook.");
        }
    }
}
