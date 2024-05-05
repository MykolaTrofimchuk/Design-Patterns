using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05.State
{
    // Стейт для визначення, чи застосовані стилі до елемента
    interface IStyleState
    {
        void Apply(LightElementNode elementNode);
    }
}
