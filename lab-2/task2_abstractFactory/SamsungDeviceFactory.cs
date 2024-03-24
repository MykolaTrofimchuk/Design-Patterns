using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_abstractFactory
{
    // Конкретна фабрика для створення техніки від бренду Samsung
    public class SamsungDeviceFactory : IDeviceFactory
    {
        public Laptop CreateLaptop()
        {
            return new GalaxyBook();
        }

        public Smartphone CreateSmartphone()
        {
            return new GalaxyPhone();
        }
    }
}
