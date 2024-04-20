using task04;

class Program
{
    // Маємо дві конкретні реалізації інтерфейсу IImageLoadingStrategy:
    // FileImageLoadingStrategy для завантаження зображення з файлової системи та NetworkImageLoadingStrategy для завантаження зображення з мережі.
    // Клас Image використовує ці стратегії для завантаження зображень, дозволяючи легко змінювати спосіб завантаження зображення за допомогою
    // методу SetLoadingStrategy.

    static void Main(string[] args)
    {
        // Створення екземпляра Image зі стратегією завантаження з файлової системи
        Image fileImage = new Image(new FileImageLoadingStrategy());
        fileImage.Load("path/to/image.jpg");

        // Зміна стратегії на завантаження з мережі
        fileImage.SetLoadingStrategy(new NetworkImageLoadingStrategy());
        fileImage.Load("https://example.com/image.jpg");

        Console.ReadLine(); 
    }
}