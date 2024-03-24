using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_builder
{
    // Базовий білдер
    interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetGender(string gender);
        ICharacterBuilder SetRace(string race);
        ICharacterBuilder SetClass(string className);
        ICharacterBuilder EquipWeapon(string weapon);
        ICharacterBuilder EquipArmor(string armor);
        Character Build();
    }
}
