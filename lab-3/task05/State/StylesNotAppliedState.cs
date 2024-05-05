using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05.State
{
    // Стан, коли стилі не застосовані
    class StylesNotAppliedState : IStyleState
    {
        public void Apply(LightElementNode elementNode)
        {
            Console.WriteLine($"Styles not applied to element {elementNode.TagName}");
        }
    }
}
