using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du räkna på en rätvinklig triangel, rektangel eller cirkel?");
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == "triangel")
                {
                    Console.WriteLine("Skriv in två tal:");
                    int width = Convert.ToInt32(Console.ReadLine());
                    int height = Convert.ToInt32(Console.ReadLine());
                    IShape tri = new tri(width, height) as IShape;
                    Console.WriteLine(tri.Area());
                    Console.WriteLine(tri.Circumferance());
                    break;
                }
                else if (answer == "rektangel")
                {
                    Console.WriteLine("Skriv in två tal:");
                    int width = Convert.ToInt32(Console.ReadLine());
                    int height = Convert.ToInt32(Console.ReadLine());
                    IShape rec = new rec(width, height) as IShape;
                    Console.WriteLine(rec.Area());
                    Console.WriteLine(rec.Circumferance());
                    break;
                }
                else if(answer == "cirkel")
                {
                    Console.WriteLine("Skriv in ett tal:");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    IShape Circle = new Circle(radius) as IShape;
                    Console.WriteLine(Circle.Area());
                    Console.WriteLine(Circle.Circumferance());
                    break;
                }
                else
                {
                    Console.WriteLine("Välj en!");
                    Console.WriteLine("Vill du räkna på en rätvinklig triangel, rektangel eller cirkel?");
                }
            }
        }
    }
}