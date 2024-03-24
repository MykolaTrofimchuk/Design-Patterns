using task3_prototype;

class Program
{
    static void Main(string[] args)
    {
        Virus firstGenerationVirus = new Virus(1.5, 1, "First Gen Virus", "A");
        Virus secondGenerationVirus1 = new Virus(1.2, 1, "Second Gen Virus 1", "B");
        Virus secondGenerationVirus2 = new Virus(1.4, 1, "Second Gen Virus 2", "B");
        Virus thirdGenerationVirus1 = new Virus(1.1, 1, "Third Gen Virus 1", "C");
        Virus thirdGenerationVirus2 = new Virus(1.3, 1, "Third Gen Virus 2", "C");

        firstGenerationVirus.AddChild(secondGenerationVirus1);
        firstGenerationVirus.AddChild(secondGenerationVirus2);
        secondGenerationVirus1.AddChild(thirdGenerationVirus1);
        secondGenerationVirus1.AddChild(thirdGenerationVirus2);

        Virus clonedVirus = (Virus)firstGenerationVirus.Clone();

        Console.WriteLine("Cloned Virus Information:");
        clonedVirus.DisplayInfo();

        Virus clonedVirus2 = (Virus)secondGenerationVirus1.Clone();

        Console.WriteLine("\nCloned Virus Information №2:");
        clonedVirus2.DisplayInfo();
    }
}
