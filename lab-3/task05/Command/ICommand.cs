using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05.Command
{
    // Команда для додавання класу до елемента
    interface ICommand
    {
        void Execute(LightElementNode elementNode);
    }
}
