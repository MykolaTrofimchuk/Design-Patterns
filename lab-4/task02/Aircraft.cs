using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Aircraft
    {
        public string Name;
        public Runway? CurrentRunway { get; set; }
        public bool IsTakingOff { get; set; }

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void Land(ControlTower controlTower)
        {
            controlTower.RequestToLand(this);
        }

        public void TakeOff(ControlTower controlTower)
        {
            controlTower.RequestToTakeOff(this);
        }
    }
}
