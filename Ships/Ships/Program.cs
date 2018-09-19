using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("napiste souradnici x");
            int playerx = Console.Read();
            Console.WriteLine("napiste souradnici y");
            int playery = Console.Read();

            List<Point> pole = new List<Point>();
            bool radek1;
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 10; j++)
                {
                    if (j == 9)
                    {
                        radek1 = true;
                    }
                    else
                    {
                        radek1 = false;
                    }
                    pole.Add(new Point
                    {
                        x = i,
                        y = j,
                        radek = radek1
                    });
                }
            }

            foreach (Point point in pole)
            {
                //Console.WriteLine($"X={point.x} a Y={point.y}-----{point.radek}");
                Console.Write("*");
                if (point.radek)
                {
                    Console.WriteLine();
                }
            }

            List<Ship> ships = new List<Ship>();
            

        }
    }
}
