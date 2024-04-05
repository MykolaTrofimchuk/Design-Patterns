using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    // Адаптер для адаптації класу Logger до інтерфейсу IFileWriter
    public class Adapter : IFileWriter
    {
        private Logger logger;

        public Adapter(Logger logger)
        {
            this.logger = logger;
        }

        public void Write(string text)
        {
            logger.Log(text);
            logger.Error(text);
            logger.Warn(text);
        }

        public void WriteLine(string text)
        {
            logger.Log(text);
            logger.Error(text);
            logger.Warn(text);
        }
    }
}
