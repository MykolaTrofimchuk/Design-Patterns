using task05;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor("Initial content");
        TextDocumentMemento initialMemento = editor.Save();
        editor.SetContent("Edited content");

        Console.WriteLine("Current content:");
        Console.WriteLine(editor);

        TextDocumentMemento initialMementoOneMore = editor.Save();

        Console.WriteLine("\nCurrent content:");
        editor.SetContent("Editing content one more time");
        Console.WriteLine(editor);

        Console.WriteLine("\n...Restoring initial content (step 1)...");
        editor.Restore(initialMemento);
        Console.WriteLine("\nRestored content:");
        Console.WriteLine(editor);

        Console.WriteLine("\n...Restoring initial content (step 2)...");
        editor.Restore(initialMementoOneMore);

        Console.WriteLine("\nRestored content:");
        Console.WriteLine(editor);

        Console.ReadLine(); 
    }
}