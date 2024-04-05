using task02;

internal class Program
{
    static void Main(string[] args)
    {
        Hero warrior = new Warrior();
        Hero mage = new Mage();
        Hero paladin = new Paladin();

        warrior = new ClothingDecorator(warrior);
        warrior = new WeaponDecorator(warrior);
        mage = new WeaponDecorator(mage);
        mage = new ArtifactDecorator(mage);
        paladin = new ClothingDecorator(paladin);
        paladin = new ArtifactDecorator(paladin);

        warrior.Display();
        warrior.Attack();

        mage.Display();
        mage.Attack();

        paladin.Display();
        paladin.Attack();
    }
}