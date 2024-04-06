using task03;

internal class Program
{
    static void Main(string[] args)
    {
        // векторнa графікa
        IDraw vectorDrawAPI = new VectorDraw();
        Shape circle = new Circle(vectorDrawAPI);
        Shape square = new Square(vectorDrawAPI);
        Shape triangle = new Triangle(vectorDrawAPI);

        circle.Draw();
        square.Draw();
        triangle.Draw();

        Console.WriteLine();

        // растровa графікa
        IDraw rasterDrawAPI = new RasterDraw();
        circle = new Circle(rasterDrawAPI);
        square = new Square(rasterDrawAPI);
        triangle = new Triangle(rasterDrawAPI);

        circle.Draw();
        square.Draw();
        triangle.Draw();
    }
}