using task01;

class Program
{
    static void Main(string[] args)
    {
        SupportHandler lowHandler = new LowSupportHandler();
        SupportHandler mediumHandler = new MediumSupportHandler();
        SupportHandler highHandler = new HighSupportHandler();
        SupportHandler expertHandler = new ExpertSupportHandler();

        lowHandler.SetNextHandler(mediumHandler);
        mediumHandler.SetNextHandler(highHandler);
        highHandler.SetNextHandler(expertHandler);

        // Симуляція запитів користувачів
        Console.WriteLine("Enter the level of your problem (from 1 to 10):");
        int level = Convert.ToInt32(Console.ReadLine());
        lowHandler.HandleRequest(level);

        Console.ReadLine();
    }
}