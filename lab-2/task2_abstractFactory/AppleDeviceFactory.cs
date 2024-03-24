using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_abstractFactory
{
    // Конкретна фабрика для створення техніки від бренду Apple
    public class AppleDeviceFactory : IDeviceFactory
    {
        public Laptop CreateLaptop()
        {
            return new MacBook();
        }

        public Smartphone CreateSmartphone()
        {
            return new IPhone();
        }
    }
}
