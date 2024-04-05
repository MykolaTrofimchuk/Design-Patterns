using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    // Декоратор для одягу
    public class ClothingDecorator : InventoryDecorator
    {
        public ClothingDecorator(Hero hero) : base(hero) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Equipping Clothing");
        }
    }
}
