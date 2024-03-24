using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_fabric
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            MonthlyFee = 15;
            MinPeriod = 3;
            Channels = new List<string> { "Educational", "Documentary" };
        }

        public override string GetDetails()
        {
            return $"Educational Subscription: ${MonthlyFee}/month,\n Minimum period: {MinPeriod} months,\n Selected channels: {string.Join(", ", Channels)}";
        }
    }
}
