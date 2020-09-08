using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfismuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du räkna på en rätvinklig triangel eller rektangel?");
            Console.ReadLine();
            if 
            {

            }
            Console.WriteLine("Skriv in två tal:");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Rectangle rec = new Rectangle(width, height);
            Triangle tri = new Triangle(width, height);

            Console.WriteLine(rec.Area());
            Console.WriteLine(tri.Area());
            Console.WriteLine(rec.Circumferance());
            Console.WriteLine(tri.Circumferance());

            Shape shape = new Triangle(width, height);
            Shape shape1 = new Rectangle(width, height);

        }
    }
}