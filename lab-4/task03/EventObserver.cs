using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    // Спостерігач для подій
    class EventObserver : IObserver
    {
        public void HandleEvent(string eventName)
        {
            Console.WriteLine($"Event '{eventName}' handled by observer.");
        }
    }
}
