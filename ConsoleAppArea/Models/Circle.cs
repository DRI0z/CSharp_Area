using ConsoleAppArea.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArea.Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return (Radius * Radius) / Math.PI;
        }
    }
}
