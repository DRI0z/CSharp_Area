using ConsoleAppArea.Models;
using ConsoleAppArea.Service;

namespace ConsoleAppArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Rectangle rectangle1 = new Rectangle(5, 10);
            Rectangle rectangle2 = new Rectangle(4, 5);

            Triangle triangle1 = new Triangle(5, 5);
            Triangle triangle2 = new Triangle(8, 2);

            Rectangle[] rectangles = { rectangle1, rectangle2 };

            Circle[] circles= { circle1, circle2 };

            Triangle[] triangles= { triangle1, triangle2 };

            var a = new TotalCalculator();

            Console.WriteLine(a.TotalArea(rectangles));
              
        }
    }
}
