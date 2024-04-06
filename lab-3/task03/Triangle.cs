using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Triangle : Shape
    {
        public Triangle(IDraw drawAPI) : base(drawAPI) { }

        public override void Draw()
        {
            Console.Write("Triangle: ");
            drawAPI.DrawShape();
        }
    }
}
