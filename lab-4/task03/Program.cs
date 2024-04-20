using task03;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode body = new LightElementNode("body", "block", "open",
            new List<string>(),
            new List<LightNode>()
            {
                new LightElementNode("h1", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Hello, LightHTML!")} ),
                new LightElementNode("ul", "block", "open", new List<string>(),
                    new List<LightNode>()
                    {
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 1")} ),
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 2")} ),
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 3")} )
                    }
                )
            }
        );
        Console.WriteLine("Body HTML:");
        Console.WriteLine(body.OuterHtml());

        // спостерігач
        EventObserver observer = new EventObserver();
        body.AddEventListener("click", observer);
        body.NotifyEventListeners("click");

        body.AddEventListener("focus", observer);
        body.NotifyEventListeners("focus");

        Console.ReadLine();
    }
}