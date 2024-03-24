using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_fabric
{
    public class WebSite
    {
        private readonly SubscriptionFactory _subscriptionFactory;

        public WebSite(SubscriptionFactory subscriptionFactory)
        {
            _subscriptionFactory = subscriptionFactory;
        }

        public Subscription BuySubscription(string subscriptionType)
        {
            // Логіка для придбання через веб-сайт
            return _subscriptionFactory.CreateSubscription(subscriptionType);
        }
    }
}
