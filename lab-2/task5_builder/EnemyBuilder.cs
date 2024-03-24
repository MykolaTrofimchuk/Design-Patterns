using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_builder
{
    class EnemyBuilder : ICharacterBuilder
    {
        private Character _enemy = new Character();

        public EnemyBuilder()
        {
            _enemy.Class = "Enemy";
        }

        public ICharacterBuilder SetName(string name)
        {
            _enemy.Name = name;
            return this;
        }

        public ICharacterBuilder SetGender(string gender)
        {
            _enemy.Gender = gender;
            return this;
        }

        public ICharacterBuilder SetRace(string race)
        {
            _enemy.Race = race;
            return this;
        }

        public ICharacterBuilder SetClass(string characterClass)
        {
            _enemy.Class = characterClass;
            return this;
        }

        public ICharacterBuilder EquipWeapon(string weapon)
        {
            _enemy.Weapon = weapon;
            return this;
        }

        public ICharacterBuilder EquipArmor(string armor)
        {
            _enemy.Armor = armor;
            return this;
        }

        public Character Build()
        {
            return _enemy;
        }
    }
}
