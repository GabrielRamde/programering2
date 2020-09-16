using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceuppgift
{
    class rec : IShape
    {
        private int height;
        private int width;
        public rec(int height, int width)
        {
            this.height = height;
            this.width = width;
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