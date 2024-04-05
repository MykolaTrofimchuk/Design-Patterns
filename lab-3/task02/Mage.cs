using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    // Конкретний клас героя Mage
    public class Mage : Hero
    {
        public override void Display()
        {
            Console.WriteLine("Mage");
        }

        public override void Attack()
        {
            Console.WriteLine("Mage attacks with magic");
        }
    }
}
