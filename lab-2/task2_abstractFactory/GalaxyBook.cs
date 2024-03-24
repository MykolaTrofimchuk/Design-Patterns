using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_abstractFactory
{
    // Конкретний клас лептопа від Samsung
    public class GalaxyBook : Laptop
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a Samsung Galaxy Book.");
        }
    }
}
