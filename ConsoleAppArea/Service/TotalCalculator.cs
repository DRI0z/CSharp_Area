using ConsoleAppArea.Models;

namespace ConsoleAppArea.Service
{
    public class TotalCalculator
    {
        public double TotalArea(object[] arrObjects)
        {
            double area = 0.0;
            Rectangle objRectangle;
            Circle objCircle;

            foreach(var obj in arrObjects)
            {
                if(obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Heigth * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
                
            }

            return area;
        }
    }
}
