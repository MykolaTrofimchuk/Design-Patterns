using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    // Конкретна стратегія завантаження зображення з файлової системи
    class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public void LoadImage(string href)
        {
            Console.WriteLine($"Loading image from file system: {href}");
        }
    }
}
