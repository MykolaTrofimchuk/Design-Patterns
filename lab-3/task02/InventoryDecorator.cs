using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    // Базовий декоратор для інвентарю
    public abstract class InventoryDecorator : Hero
    {
        protected Hero hero;

        public InventoryDecorator(Hero hero)
        {
            this.hero = hero;
        }

        public override void Display()
        {
            hero.Display();
        }

        public override void Attack()
        {
            hero.Attack();
        }
    }
}
