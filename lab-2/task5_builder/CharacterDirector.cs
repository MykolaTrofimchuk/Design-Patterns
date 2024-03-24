using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_builder
{
    // Клас-директор - відповідає за конструювання персонажів
    class CharacterDirector
    {
        private ICharacterBuilder _builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.SetName("Hero")
                    .SetGender("Male")
                    .SetRace("Human")
                    .SetClass("Warrior")
                    .EquipWeapon("Sword")
                    .EquipArmor("Plate Armor");
        }
    }
}
