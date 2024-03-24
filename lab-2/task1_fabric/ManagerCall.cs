using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_fabric
{
    public class ManagerCall
    {
        private readonly SubscriptionFactory _subscriptionFactory;

        public ManagerCall(SubscriptionFactory subscriptionFactory)
        {
            _subscriptionFactory = subscriptionFactory;
        }

        public Subscription BuySubscription(string subscriptionType)
        {
            // Логіка для придбання через дзвінок менеджеру
            return _subscriptionFactory.CreateSubscription(subscriptionType);
        }
    }
}
