using task5_builder;

internal class Program
{
    static void Main(string[] args)
    {
        ICharacterBuilder heroBuilder = new HeroBuilder();

        CharacterDirector director = new CharacterDirector(heroBuilder);

        director.Construct();
        Character hero = heroBuilder.Build();

        Console.WriteLine("Hero:");
        Console.WriteLine(hero);

        Character anotherHero = new HeroBuilder()
            .SetName("Another Hero")
            .SetGender("Female")
            .SetRace("Elf")
            .SetClass("Archer")
            .EquipWeapon("Bow")
            .EquipArmor("Leather Armor")
            .Build();

        Console.WriteLine("\nAnother Hero:");
        Console.WriteLine(anotherHero);

        ICharacterBuilder enemyBuilder = new EnemyBuilder();

        Character enemy = enemyBuilder
            .SetName("Evil Villain")
            .SetGender("Male")
            .SetRace("Orc")
            .SetClass("Warrior")
            .EquipWeapon("Axe")
            .EquipArmor("Plate Armor")
            .Build();

        Console.WriteLine("\nEnemy:");
        Console.WriteLine(enemy);
    }
}