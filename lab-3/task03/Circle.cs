using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Circle : Shape
    {
        public Circle(IDraw drawAPI) : base(drawAPI) { }

        public override void Draw()
        {
            Console.Write("Circle: ");
            drawAPI.DrawShape();
        }
    }
}
