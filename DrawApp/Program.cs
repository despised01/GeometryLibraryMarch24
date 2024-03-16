using GeometryLibraryMarch24;

namespace DrawApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures =
            {
                new Circle(5),
                new Ellipse(8, 6),
                new Triangle(4, 7, 9),
                new Square(5),
                new Quadrilateral(5, 9, 5, 9)
            };

            foreach (Figure figure  in figures)
            {
                Console.WriteLine($"Площадь фигуры {figure.GetType().Name}: {figure.Area()}");
                figure.Draw();
                Console.WriteLine();
            }
        }
    }
}