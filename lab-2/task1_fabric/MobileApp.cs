using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_fabric
{
    public class MobileApp
    {
        private readonly SubscriptionFactory _subscriptionFactory;

        public MobileApp(SubscriptionFactory subscriptionFactory)
        {
            _subscriptionFactory = subscriptionFactory;
        }

        public Subscription BuySubscription(string subscriptionType)
        {
            // Логіка для придбання через мобільний додаток
            return _subscriptionFactory.CreateSubscription(subscriptionType);
        }
    }
}
