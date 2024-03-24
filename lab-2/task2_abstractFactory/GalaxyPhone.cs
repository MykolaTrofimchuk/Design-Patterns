using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_abstractFactory
{
    // Конкретний клас смартфона від Samsung
    public class GalaxyPhone : Smartphone
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a Samsung Galaxy Phone.");
        }
    }
}
