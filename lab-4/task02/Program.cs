using task02;

class Program
{
    static void Main(string[] args)
    {
        List<Runway> runways = new List<Runway>();
        for (int i = 0; i < 3; i++) 
        {
            runways.Add(new Runway());
        }

        List<Aircraft> aircrafts = new List<Aircraft>();
        aircrafts.Add(new Aircraft("Boeing 747"));
        aircrafts.Add(new Aircraft("Airbus A320"));
        aircrafts.Add(new Aircraft("Cessna 172"));

        ControlTower controlTower = new ControlTower(runways, aircrafts);

        foreach (var aircraft in aircrafts)
        {
            aircraft.Land(controlTower);
            aircraft.TakeOff(controlTower);
        }

        Console.ReadLine(); 
    }
}