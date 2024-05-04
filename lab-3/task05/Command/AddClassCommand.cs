using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05.Command
{
    // реалізація команди
    class AddClassCommand : ICommand
    {
        private string _cssClass;

        // Змінений конструктор для відповідності переданому виклику
        public AddClassCommand(string cssClass)
        {
            _cssClass = cssClass;
        }

        public void Execute(LightElementNode elementNode)
        {
            elementNode.AddCssClass(_cssClass);
        }
    }
}
