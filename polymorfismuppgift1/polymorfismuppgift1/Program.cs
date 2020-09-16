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
            string answer = Console.ReadLine();
            if (answer == "triangel")
            {
                Console.WriteLine("Skriv in två tal:");
                int width = Convert.ToInt32(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());
                Shape tri = new tri(width, height);
                Console.WriteLine(tri.Area());
                Console.WriteLine(tri.Circumferance());
            }
            else if (answer == "rektangel")
            {
                Console.WriteLine("Skriv in två tal:");
                int width = Convert.ToInt32(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());
                Shape rec = new rec(width, height);
                Console.WriteLine(rec.Area());
                Console.WriteLine(rec.Circumferance());  
                break;
            }
            else
            {
                Console.WriteLine("Välj en!");
            }

        }
    }
}
