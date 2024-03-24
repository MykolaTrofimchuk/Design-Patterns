using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_fabric
{
    // Абстрактний клас підписки
    public abstract class Subscription
    {
        public double MonthlyFee { get; protected set; }
        public int MinPeriod { get; protected set; }
        public List<string> Channels { get; protected set; }

        public abstract string GetDetails();
    }
}
