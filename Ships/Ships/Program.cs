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


        public static void addShip()
        {
            List<Ship> ship = new List<Ship>();
            Ship shiptest = new Ship();
            int selectedMenuShip = drawMenu();
            switch (selectedMenuShip)
            {
                case 0:
                    ship.Add(new Ship
                    {
                        type = "Ponorka",

                        /*posX = new List<int>() { 0 },
                        posY = new List<int>() { 0 }*/
                    });
                    shiptest.posX.Add(0);
                    shiptest.posY.Add(0);
                    break;
                default:
                    break;
            }
        }



        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int naviX = 0;
            int naviY = 0;
            

            int ponorky = 1;
            int ponorkyCount = 1;
            int torpedoborce = 0;
            int krizniky = 0;
            int bitevnilode = 0;

            int pocetlodi = ponorkyCount + torpedoborce + krizniky + bitevnilode;

            List<Ship> ship = new List<Ship>();
            Ship shiptest = new Ship();

            for (int i = 0; i < ponorky; i++)
            {
                /*ship.Add(new Ship
                {
                    type = "Ponorka",
                    posX = new List<int>() { 0 },
                    posY = new List<int>() { 0 }
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
                                    /*x = shipx,
                                    y = shipy,*/
                                    type = "Ponorka"
                                });
                                shiptest.posX.Add(0);
                                shiptest.posY.Add(0);
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







            List<Point> pole = new List<Point>();
            bool radek1;
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
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
                        x = j,
                        y = i,
                        radek = radek1
                    });
                }
            }

            Ship ship2 = new Ship();
            
            Console.WriteLine(shiptest.posX[0]);
            //List<Ship> posX = new List<Ship>();
            while (true)
            {
                bool tryAdd = false;
                ConsoleKeyInfo navigation = Console.ReadKey();
                
                if (navigation.Key == ConsoleKey.RightArrow)
                {
                    if (naviX < width - 1) { naviX++; /*posX = posX.Select(x => x+1).ToList();*/  }
                }
                else if (navigation.Key == ConsoleKey.LeftArrow)
                {
                    if (naviX > 0) { naviX--; }
                }
                else if (navigation.Key == ConsoleKey.UpArrow)
                {
                    if (naviY > 0) { naviY--; }
                }
                else if (navigation.Key == ConsoleKey.DownArrow)
                {
                    if (naviY < width-1) { naviY++; }
                }
                else if (navigation.Key == ConsoleKey.Enter)
                {
                    tryAdd = true;
                }
                Console.Clear();
                Console.WriteLine();
                //Console.WriteLine(posX[1]);
                Console.WriteLine();

                foreach (Point point in pole)
                {
                    if (tryAdd)
                    {
                        if (point.ship == false && point.x == naviX && point.y == naviY)
                        {
                            point.ship = true;
                        }
                    }
                    //Console.WriteLine($"X={point.x} a Y={point.y}-----{point.radek}");

                    /*if (playerx == point.x && playery == point.y)
                    {
                        Console.Write("+");
                    }*/
                    if (point.x == naviX && point.y == naviY)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("*");

                    }
                    else if (point.ship)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                    if (point.radek)
                    {
                        Console.WriteLine();
                    }
                    Console.ResetColor();
                }
                
            }


            List<Ship> ships = new List<Ship>();
            

        }
    }
}
