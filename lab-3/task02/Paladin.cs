using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    // Конкретний клас героя Paladin
    public class Paladin : Hero
    {
        public override void Display()
        {
            Console.WriteLine("Paladin");
        }

        public override void Attack()
        {
            Console.WriteLine("Paladin attacks with hammer");
        }
    }
}
