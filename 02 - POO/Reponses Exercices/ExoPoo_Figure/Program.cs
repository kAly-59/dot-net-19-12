using ExoPoo_Figure.Classes;

public class Program
{
    public static void Main()
    {
        Point point = new Point(2, 2);

        Carre carre = new Carre(point, 2);
        Rectangle rectangle = new Rectangle(point, 3, 5);
        Triangle triangle = new Triangle(point, 4, 5);

        Console.WriteLine(carre.ToString());
        Console.WriteLine(carre.CoordonneesDesCotes());
        Console.WriteLine(rectangle.ToString());
        Console.WriteLine(rectangle.CoordonneesDesCotes());
        Console.WriteLine(triangle.ToString());
        Console.WriteLine(triangle.CoordonneesDesCotes());

        carre.Deplacement(3, 3);
        Console.WriteLine(carre.ToString());
        Console.WriteLine(carre.CoordonneesDesCotes());
        rectangle.Deplacement(2, 2);
        Console.WriteLine(rectangle.ToString());
        Console.WriteLine(rectangle.CoordonneesDesCotes());
        triangle.Deplacement(4, 4);
        Console.WriteLine(triangle.ToString());
        Console.WriteLine(triangle.CoordonneesDesCotes());

    }
}