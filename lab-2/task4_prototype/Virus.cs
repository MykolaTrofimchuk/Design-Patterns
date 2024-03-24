using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_prototype
{
    // Клонування відбувається за допомогою інтерфейсу ICloneable, який дозволяє створювати глибокі копії об'єктів. У класі Virus реалізовано метод Clone(),
    // який створює новий об'єкт Virus з такими ж властивостями, як у вихідному вірусі. Після цього рекурсивно клонуються всі діти вихідного вірусу і
    // додаються до клонованого вірусу.
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string kind)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Kind = kind;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clonedVirus = new Virus(Weight, Age, Name, Kind);

            foreach (var child in Children)
            {
                clonedVirus.AddChild((Virus)child.Clone());
            }

            return clonedVirus;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Virus Kind: {Kind}, Weight: {Weight}, Age: {Age}");
            Console.WriteLine("Children:");
            foreach (var child in Children)
            {
                Console.WriteLine($" - {child.Name}");
            }
            Console.WriteLine();
        }
    }
}
