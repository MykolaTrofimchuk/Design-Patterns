using task01;

internal class Program
{
    private static void Main(string[] args)
    {
        // Створення файлового логера через адаптер
        var logger = new Logger();
        var fileLogger = new Adapter(logger);

        // Використання логера
        fileLogger.Write("Message");
        Console.WriteLine(" ");
        fileLogger.WriteLine("Message");

        Console.WriteLine("\nLogs was added.");
    }
}