using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Program
    {
        private static int index = 0;
        private static int width = 20;
        private static int height = 20;
        private static void map()
        {

        }

        private static void createShips()
        {
            

            


        }

        private static int drawMenu()
        {
            //int index = 0;
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
                if (index == shipTypeCount - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = shipTypeCount-1;
                }
                else
                {
                    index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return index;
            }
            else
            {
                return 0;
            }

            
            Console.Clear();
            return 100;

        }
        static void Main(string[] args)
        {

            Console.CursorVisible = false;

            int ponorky = 0;
            int ponorkyCount = 0;
            int torpedoborce = 0;
            int krizniky = 0;
            int bitevnilode = 0;

            int pocetlodi = ponorkyCount + torpedoborce + krizniky + bitevnilode;

            List<Ship> ship = new List<Ship>();

            for (int i = 0; i < ponorky; i++)
            {
                /*ship.Add(new Ship
                {
                    type = "Ponorka",
                    x = 2
                });*/
            }


            while (pocetlodi > 0)
            {
                pocetlodi = ponorkyCount + torpedoborce + krizniky + bitevnilode;
                Console.WriteLine(pocetlodi);
                int selectedMenuIndex = drawMenu();
                if (selectedMenuIndex == 100)
                {

                }
                else if (selectedMenuIndex == 0)
                {
                    if (ponorkyCount > 0)
                    {
                        for (int i = 0; i < ponorky; i++)
                        {
                            bool add = true;
                            Console.Clear();

                            Console.WriteLine($"Rozmisěte {ponorkyCount} ponorek");
                            Console.WriteLine("napiste souradnici x");
                            int shipx = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("napiste souradnici y");
                            int shipy = Convert.ToInt32(Console.ReadLine());

                            if (ship.Count() != 0)
                            {
                                foreach (Ship lod in ship)
                                {
                                    /*Console.WriteLine($"x lode = {lod.x}, y lode = {lod.y}");
                                    Console.WriteLine($"x inputu = {shipx}, y inputu = {shipy}");*/
                                    if (shipx == lod.x && shipy == lod.y)
                                    {
                                        add = false;
                                        Console.WriteLine("Pozice je obsazená");
                                        i--;
                                    }
                                }
                            }

                            if (add == true)
                            {
                                ship.Add(new Ship
                                {
                                    x = shipx,
                                    y = shipy,
                                    type = "Ponorka"
                                });
                                ponorkyCount--;
                            }

                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti ponorky");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (selectedMenuIndex == 1)
                {
                    Console.Clear();
                    Console.WriteLine("VYBRAL SI MOŽNOST 1");
                    Console.Read();
                }
            }





            /*foreach (ShipTypes shipType in Enum.GetValues(typeof(ShipTypes)))
            {
                Console.WriteLine(shipType);
            }*/

            Console.WriteLine("napiste souradnici x");
            int playerx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("napiste souradnici y");
            int playery = Convert.ToInt32(Console.ReadLine());

            List<Point> pole = new List<Point>();
            bool radek1;
            for (int i = 0; i < width; i++)
            {

                for (int j = 0; j < height; j++)
                {
                    if (j == width - 1)
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



            /*foreach (Point point in pole)
            {
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
            }*/



                while (true)
                {
                    ConsoleKeyInfo navigation = Console.ReadKey();
                    int naviX = 0;
                    int naviY = 0;
                    if (navigation.Key == ConsoleKey.DownArrow)
                    {
                        if (naviX<width-1)
                        {
                            naviX++;
                        }  
                    }
                    else if (navigation.Key == ConsoleKey.LeftArrow)
                    {
                        if (naviX>0)
                        {
                            naviX--;
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
                }


                List<Ship> ships = new List<Ship>();
            

        }
    }
}
