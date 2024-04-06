using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task04
{
    // Проксі для SmartTextReader з обмеженням доступу
    class SmartTextReaderLocker : SmartTextReader
    {
        private Regex restrictedFilesRegex;

        public SmartTextReaderLocker(string regexPattern)
        {
            restrictedFilesRegex = new Regex(regexPattern);
        }

        public new char[,] ReadText(string filePath)
        {
            if (restrictedFilesRegex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return new char[0, 0];
            }
            else
            {
                return base.ReadText(filePath);
            }
        }
    }
}
