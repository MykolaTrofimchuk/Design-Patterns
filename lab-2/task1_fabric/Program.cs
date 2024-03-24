using task1_fabric;

internal class Program
{
    private static void Main(string[] args)
    {
        // Приклад використання фабричного методу через класи WebSite, MobileApp та ManagerCall
        string subscriptionType = "premium";
        SubscriptionFactory subscriptionFactory = new SubscriptionFactory();
        Subscription subscriptionFromWebsite = new WebSite(subscriptionFactory).BuySubscription(subscriptionType);
        Subscription subscriptionFromMobileApp = new MobileApp(subscriptionFactory).BuySubscription(subscriptionType);
        Subscription subscriptionFromManagerCall = new ManagerCall(subscriptionFactory).BuySubscription(subscriptionType);

        Console.WriteLine(subscriptionFromWebsite.GetDetails());
        Console.WriteLine(subscriptionFromMobileApp.GetDetails());
        Console.WriteLine(subscriptionFromManagerCall.GetDetails());
    }
}