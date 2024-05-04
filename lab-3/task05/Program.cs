using task05;
using task05.Command;

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

        // Додавання класу до елемента за допомогою команди
        ICommand addClassCommand = new AddClassCommand("highlight");
        addClassCommand.Execute(body);

        Console.WriteLine(body.OuterHtml());
    }
}