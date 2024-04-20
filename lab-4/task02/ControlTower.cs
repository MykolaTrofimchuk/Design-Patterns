using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class ControlTower
    {
        private List<Runway> _runways;
        private List<Aircraft> _aircrafts;

        public ControlTower(List<Runway> runways, List<Aircraft> aircrafts)
        {
            _runways = runways;
            _aircrafts = aircrafts;
        }

        public void RequestToLand(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                    Console.WriteLine($"Checking runway.");
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    runway.IsBusyWithAircraft = aircraft;
                    runway.HighLightRed();
                    aircraft.CurrentRunway = runway;
                    return;
                }
            }
            Console.WriteLine($"Could not land, all runways are busy.");
        }

        public void RequestToTakeOff(Aircraft aircraft)
        {
            if (aircraft.CurrentRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
                aircraft.CurrentRunway.IsBusyWithAircraft = null;
                aircraft.CurrentRunway.HighLightGreen();
                aircraft.CurrentRunway = null;
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}
