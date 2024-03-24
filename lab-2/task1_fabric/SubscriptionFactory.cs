using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_fabric
{
    public class SubscriptionFactory
    {
        public Subscription CreateSubscription(string subscriptionType)
        {
            switch (subscriptionType.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription();
                case "educational":
                    return new EducationalSubscription();
                case "premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Invalid subscription type.");
            }
        }
    }
}
