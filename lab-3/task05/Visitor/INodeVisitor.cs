using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05.Visitor
{
    // Відвідувач для візуалізації елементів
    interface INodeVisitor
    {
        void Visit(LightElementNode elementNode);
        void Visit(LightTextNode textNode);
    }
}
