using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_abstractFactory
{
    // Абстрактна фабрика техніки
    public interface IDeviceFactory
    {
        Laptop CreateLaptop();
        Smartphone CreateSmartphone();
    }
}
