using task05;

class Program
{
    static void Main(string[] args)
    {
        // використання шаблону Компонувальник
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
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 3")} ),
                        new LightElementNode("li", "block", "closed", new List<string>(), new List<LightNode>(){new LightTextNode("Item 4")} )
                    }
                )
            }
        );

        Console.WriteLine(body.OuterHtml());
        Console.WriteLine();

        // Ітератор: Перебір документу в глибину
        Console.WriteLine("Depth-first traversal:");
        foreach (var node in body.DepthFirstIterator())
        {
            Console.WriteLine(node.GetType().Name);
        }

        // Ітератор: Перебір документу в ширину
        Console.WriteLine("\nBreadth-first traversal:");
        foreach (var node in body.BreadthFirstIterator())
        {
            Console.WriteLine(node.GetType().Name);
        }
    }
}