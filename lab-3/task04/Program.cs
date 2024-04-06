using task04;

internal class Program
{
    static void Main(string[] args)
    {
        SmartTextChecker checker = new SmartTextChecker();

        char[,] textArray1 = checker.ReadText("sample.txt");

        Console.WriteLine("Text Array 1:");
        PrintTextArray(textArray1);

        Console.WriteLine();

        // екземпляри SmartTextReaderLocker з обмеженням доступу до файлів по регулярному виразу
        SmartTextReaderLocker locker = new SmartTextReaderLocker("restricted.*");
        char[,] textArray2 = locker.ReadText("restricted_file.txt");

        Console.WriteLine("Text Array 2:");
        PrintTextArray(textArray2);

        Console.WriteLine();

        SmartTextReaderLocker oper = new SmartTextReaderLocker("abuse.*");
        char[,] textArray3 = oper.ReadText("restricted_file.txt");

        Console.WriteLine("Text Array 3:");
        PrintTextArray(textArray3);
    }

    static void PrintTextArray(char[,] textArray)
    {
        for (int i = 0; i < textArray.GetLength(0); i++)
        {
            for (int j = 0; j < textArray.GetLength(1); j++)
            {
                Console.Write(textArray[i, j]);
            }
            Console.WriteLine('\t');
        }
    }
}