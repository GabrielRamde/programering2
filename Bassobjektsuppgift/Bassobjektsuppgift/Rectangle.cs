using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassobjektsuppgift
{
    class Rectangle : Shape
    {
        public Rectangle(int height, int width):base(height, width)
        {          
        }
        public double Area()
        {
            double area = width * height;
            return area;
        }
        public double Circumferance()
        {
            double circumferance = 2 * width + 2 * height;
            return circumferance;
        }
    }
}
