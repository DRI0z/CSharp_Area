using ConsoleAppArea.Models;
using System.Diagnostics.Metrics;

namespace ConsoleAppArea.Service
{
    public class TotalCalculator
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0.0;

            foreach(var arrShape in arrShapes)
            {
                area += arrShape.Area();
            }

            return area;
        }
    }
}
