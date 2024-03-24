using task3_singleton;

internal class Program
{
    static void Main(string[] args)
    {
        Authenticator authenticator1 = Authenticator.GetInstance();
        Authenticator authenticator2 = Authenticator.GetInstance();

        Console.WriteLine($"Are authenticator1 and authenticator2 the same instance? {(authenticator1 == authenticator2 ? "Yes" : "No")}");
    }
}