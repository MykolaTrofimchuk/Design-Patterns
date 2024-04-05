using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    public interface IFileWriter
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
