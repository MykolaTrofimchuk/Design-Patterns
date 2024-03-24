using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace task1_fabric
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            MonthlyFee = 25;
            MinPeriod = 6;
            Channels = new List<string> { "Sports", "Movies", "Documentary", "Entertainment", "All Inclusive" };
        }

        public override string GetDetails()
        {
            return $"Premium Subscription: ${MonthlyFee}/month,\n minimum period: {MinPeriod} months,\n Selected channels: {string.Join(", ", Channels)}";
        }
    }
}
