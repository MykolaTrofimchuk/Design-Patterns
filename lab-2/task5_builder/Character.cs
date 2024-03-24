using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_builder
{
    // Персонаж гри
    internal class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public string Weapon { get; set; }
        public string Armor { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Race: {Race}, Class: {Class}, Weapon: {Weapon}, Armor: {Armor}";
        }
    }
}
