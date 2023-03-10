using ConsoleAppArea.Service;

namespace ConsoleAppArea.Models
{
    public class Rectangle : Shape
    {
        public int Heigth { get; set; }
        public int Width { get; set; }

        public Rectangle(int heigth, int width)
        {
            Heigth = heigth;
            Width = width;
        }

        public override double Area()
        {
            return Heigth * Width;
        }
    }
}
