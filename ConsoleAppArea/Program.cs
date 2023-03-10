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

            Triangle triangle = new Triangle(5, 5, 5);

            Rectangle[] rectangles = { rectangle1, rectangle2 };

            Circle[] circles= { circle1, circle2 };

            var a = new TotalCalculator();

            Console.WriteLine(a.TotalArea(rectangles));
        }
    }
}
