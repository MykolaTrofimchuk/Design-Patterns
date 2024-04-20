using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{

    // Клас підписки спостерігача
    class EventSubscription
    {
        public IObserver Observer { get; private set; }
        public string EventName { get; private set; }

        public EventSubscription(IObserver observer, string eventName)
        {
            Observer = observer;
            EventName = eventName;
        }
    }
}
