using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace task1_fabric
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            MonthlyFee = 10;
            MinPeriod = 1;
            Channels = new List<string> { "News", "Entertainment" };
        }

        public override string GetDetails()
        {
            return $"Domestic Subscription: ${MonthlyFee}/month\n, Minimum period: {MinPeriod} month\n, Selected channels: {string.Join(", ", Channels)}";
        }
    }
}
