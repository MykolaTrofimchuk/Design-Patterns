using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_builder
{
    // Білдер створення героя
    class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetGender(string gender)
        {
            _character.Gender = gender;
            return this;
        }

        public ICharacterBuilder SetRace(string race)
        {
            _character.Race = race;
            return this;
        }

        public ICharacterBuilder SetClass(string className)
        {
            _character.Class = className;
            return this;
        }

        public ICharacterBuilder EquipWeapon(string weapon)
        {
            _character.Weapon = weapon;
            return this;
        }

        public ICharacterBuilder EquipArmor(string armor)
        {
            _character.Armor = armor;
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}
