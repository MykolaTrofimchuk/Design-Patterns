using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    // Конкретний клас героя Warrior
    public class Warrior : Hero
    {
        public override void Display()
        {
            Console.WriteLine("Warrior");
        }

        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with sword");
        }
    }
}
