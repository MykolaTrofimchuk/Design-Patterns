using System.Net;
using task06;

class Program
{
    static void Main(string[] args)
    {
        string bookUrl = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
        string bookText;
        using (WebClient client = new WebClient())
        {
            bookText = client.DownloadString(bookUrl);
        }

        List<ILightweightElement> elements = new List<ILightweightElement>();
        string[] lines = bookText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        bool firstLine = true;
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string processedLine;
            if (firstLine)
            {
                processedLine = $"<h1>{line}</h1>";
                firstLine = false;
            }
            else if (line.Length < 20)
            {
                processedLine = $"<h2>{line}</h2>";
            }
            else if (line.StartsWith(" "))
            {
                processedLine = $"<blockquote>{line}</blockquote>";
            }
            else
            {
                processedLine = $"<p>{line}</p>";
            }

            elements.Add(new LightTextNode(processedLine));
        }

        LightElementNode body = new LightElementNode("body", elements);
        Console.WriteLine(body.OuterHtml());

        int totalSize = 0;
        foreach (var element in elements)
        {
            totalSize += element.GetSize();
        }
        Console.WriteLine($"Total size of the HTML tree in memory: {totalSize} bytes.");
    }
}