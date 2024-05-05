using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05.Visitor
{
    // Конкретна реалізація відвідувача
    class ElementVisualizer : INodeVisitor
    {
        public void Visit(LightElementNode elementNode)
        {
            // Виконання завдань для елемента розмітки
            Console.WriteLine($"Visiting element {elementNode.TagName}");
        }

        public void Visit(LightTextNode textNode)
        {
            // Виконання завдань для текстового вузла
            Console.WriteLine("Visiting text node");
        }
    }
}
