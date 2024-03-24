using task2_abstractFactory;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо фабрики для Apple та Samsung
        IDeviceFactory appleFactory = new AppleDeviceFactory();
        IDeviceFactory samsungFactory = new SamsungDeviceFactory();

        // Створюємо лептоп та смартфон від Apple
        Laptop appleLaptop = appleFactory.CreateLaptop();
        Smartphone applePhone = appleFactory.CreateSmartphone();

        // Створюємо лептоп та смартфон від Samsung
        Laptop samsungLaptop = samsungFactory.CreateLaptop();
        Smartphone samsungPhone = samsungFactory.CreateSmartphone();

        // Показуємо інформацію про створену техніку
        appleLaptop.DisplayInfo();
        applePhone.DisplayInfo();
        samsungLaptop.DisplayInfo();
        samsungPhone.DisplayInfo();
    }
}