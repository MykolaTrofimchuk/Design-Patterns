using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    // Проксі для SmartTextReader з логуванням
    class SmartTextChecker : SmartTextReader
    {
        public new char[,] ReadText(string filePath)
        {
            Console.WriteLine("Opening file: " + filePath);
            char[,] textArray = base.ReadText(filePath);
            Console.WriteLine("Reading file: " + filePath);
            Console.WriteLine($"Total lines: {textArray.GetLength(0)}, Total characters: {textArray.Length}");
            Console.WriteLine("Closing file: " + filePath);
            return textArray;
        }
    }
}
