using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Menu
    {
        private static int index = 0;
        public static int MenuCreate()
        {
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
                    index = shipTypeCount - 1;
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
        /*private List<Ship> ship = new List<Ship>();
        public List<Ship> Ships()
        {
            return ship;
        } */

        public void MenuGenerate()
        {
            
            GameBoard gameboard = new GameBoard();
            List<Ship> gameShips = gameboard.Ships();

            int ponorky = 1;
            int ponorkyCount = 1;
            int torpedoborce = 1;
            int torpedoborceCount = 1;
            int krizniky = 0;
            int kriznikyCount = 0;
            int bitevnilode = 0;
            int bitevnilodeCount = 0;

            int pocetlodi = ponorkyCount + torpedoborce + krizniky + bitevnilode;

            while (pocetlodi > 0)
            {
                List<int> naviX = new List<int>();
                List<int> naviY = new List<int>();
                pocetlodi = ponorkyCount + torpedoborceCount + kriznikyCount + bitevnilodeCount;

                Console.WriteLine(pocetlodi);
                int selectedMenuIndex = MenuCreate();
                if (selectedMenuIndex == 100)
                {

                }
                else if (selectedMenuIndex == 0)
                {
                    if (ponorkyCount > 0)
                    {
                        for (int i = 0; i < ponorky; i++)
                        {
                            if (ponorkyCount > 0)
                            {
                                naviX.Clear();
                                naviY.Clear();
                                naviX.Add(0);
                                naviX.Add(1);
                                naviY.Add(0);
                                naviY.Add(1);

                                bool add = true;
                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {ponorkyCount} ponorek");
                                gameboard.GameBoardShow(naviX, naviY);

                                if (gameShips.Count() != 0)
                                {
                                    foreach (Ship lod in gameShips)
                                    {
                                        for (int o = 0; o < naviX.Count(); o++)
                                        {
                                            for (int j = 0; j < naviY.Count(); j++)
                                            {

                                                if (lod.posX.Contains(naviX[o]) && lod.posY.Contains(naviY[j]))
                                                {
                                                    add = false;
                                                    Console.WriteLine("Pozice je obsazená");
                                                    i--;
                                                }
                                            }
                                        }
                                    }
                                }

                                if (add == true)
                                {
                                    gameShips.Add(new Ship
                                    {
                                        type = "Ponorka",
                                        posX = naviX,
                                        posY = naviY
                                    });

                                    ponorkyCount--;
                                    foreach (Point policko in gameboard.GetGameBoard())
                                    {
                                        if (naviX.Contains(policko.x) && naviY.Contains(policko.y))
                                        {
                                            policko.ship = true;
                                        }
                                    }

                                }
                            }


                        }
                        Console.ReadLine();
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
                    if (torpedoborceCount > 0)
                    {
                        for (int i = 0; i < torpedoborce; i++)
                        {
                            if (torpedoborceCount > 0)
                            { 
                                naviX.Clear();
                                naviY.Clear();
                                naviX.Add(0);
                                naviY.Add(0);
                                naviY.Add(1);
                                bool add = true;
                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {torpedoborceCount} torpedoborce");
                                gameboard.GameBoardShow(naviX, naviY);

                                if (gameShips.Count() != 0)
                                {
                                    foreach (Ship lod in gameShips)
                                    {
                                        for (int o=0; o < naviX.Count(); o++)
                                        {
                                            for (int j = 0; j < naviY.Count(); j++)
                                            {

                                                if (lod.posX.Contains(naviX[o]) && lod.posY.Contains(naviY[j]))
                                                {
                                                    add = false;
                                                    Console.WriteLine("Pozice je obsazená");
                                                    i--;
                                                }
                                            }
                                        }
                                    }
                                }

                                if (add == true)
                                {
                                    gameShips.Add(new Ship
                                    {
                                        type = "Torpedoborec",
                                        posX = naviX,
                                        posY = naviY
                                    });
                                    torpedoborceCount--;
                                    foreach (Point point in gameboard.GetGameBoard())
                                    {
                                        if (naviX.Contains(point.x) && naviY.Contains(point.y))
                                        {
                                            point.ship = true;
                                        }
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti torpedoborce");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
