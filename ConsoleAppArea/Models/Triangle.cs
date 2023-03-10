using ConsoleAppArea.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArea.Models
{
    public class Triangle : Shape
    {
        public int Side { get; set; }
        public int High { get; set; }

        public Triangle(int side, int high)
        {
            Side = side;
            High = high;
        }

        public override double Area() 
        {
            return (Side * High) / 2;
        }
    }
}
