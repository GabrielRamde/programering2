using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfismuppgift1
{
    class rec : Shape
    {
        public rec(int height, int width) : base(height, width)
        {
        }
        public override double Area()
        {
            double area = width * height;
            return area;
        }
        public override double Circumferance()
        {
            double circumferance = 2 * width + 2 * height;
            return circumferance;
        }
    }
}
