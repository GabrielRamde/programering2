using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceuppgift
{
    class tri : IShape
    {
        private int height;
        private int width;
        public tri(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public double Area()
        {
            double area = width * height / 2;
            return area;
        }
        public double Circumferance()
        {
            double circumferance = Math.Sqrt(width * width + height * height);
            return circumferance;
        }
    }
}
