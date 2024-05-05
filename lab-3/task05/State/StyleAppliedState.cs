using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05.State
{
    // Стан, коли стилі застосовані
    class StyleAppliedState : IStyleState
    {
        public void Apply(LightElementNode elementNode)
        {
            // Встановлюємо стиль для елемента body
            elementNode.AddCssStyle("background-color: yellow;");

            Console.WriteLine($"Styles applied to element {elementNode.TagName}");
        }
    }
}
