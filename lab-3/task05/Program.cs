using System;
using System.Collections.Generic;
using task05;
using task05.Command;
using task05.Visitor;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо елементи розмітки
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

        // Виводимо елемент розмітки після додавання класу
        Console.WriteLine("\nAfter adding class:");
        Console.WriteLine(body.OuterHtml());
        Console.WriteLine();

        // Застосовуємо стилі до елементу
        body.ApplyStyles();

        // Виводимо елемент розмітки після застосування стилів
        Console.WriteLine("\nAfter applying styles:");
        Console.WriteLine(body.OuterHtml());

        // Створення відвідувача для інших завдань
        ElementVisualizer otherVisitor = new ElementVisualizer();

        // Прийняття відвідувача елементами розмітки для виконання інших завдань
        body.Accept(otherVisitor);
    }
}