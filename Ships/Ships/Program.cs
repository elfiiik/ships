using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Program
    {
        private static int drawMenu()
        {
            int index = 0;
            int shipTypeCount = Enum.GetNames(typeof(ShipTypes)).Length;
            for (int i = 0; i < shipTypeCount; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine((ShipTypes)i);
                }
                else
                {
                    Console.WriteLine((ShipTypes)i);
                }
                Console.ResetColor();
            }
            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == shipTypeCount - 1) { index = 0; }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index == shipTypeCount - 1) { index = 0; }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return index;
            }
            else
            {
                return index;
            }

            
            Console.Clear();
            return 0;

        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;


            int index = 0;
            int shipTypeCount = Enum.GetNames(typeof(ShipTypes)).Length;
            while (true)
            {
                int selectedMenuIndex = drawMenu();
                if (selectedMenuIndex == 0)
                {
                    Console.Clear();
                    Console.WriteLine("VYBRAL SI MOŽNOST 0");
                    Console.Read();
                }
            }


            


            foreach (ShipTypes shipType in Enum.GetValues(typeof(ShipTypes)))
            {
                Console.WriteLine(shipType);
            }


            Console.WriteLine("Vyberte loď");
            string playerShip = Console.ReadLine();
            Console.WriteLine("napiste souradnici x");
            int playerx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("napiste souradnici y");
            int playery = Convert.ToInt32(Console.ReadLine());

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
                
                if (playerx == point.x && playery == point.y)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("*");
                }

                if (point.radek)
                {
                    Console.WriteLine();
                }
            }

            List<Ship> ships = new List<Ship>();
            

        }
    }
}
