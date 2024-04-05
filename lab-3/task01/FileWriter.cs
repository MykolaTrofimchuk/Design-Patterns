using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    public class FileWriter : IFileWriter
    {
        private string filePath;

        public FileWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(string text)
        {
            File.WriteAllText(filePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(filePath, $"{text}{Environment.NewLine}");
        }
    }
}
