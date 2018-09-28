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
            List<int> naviX = gameboard.GetNaviX();
            List<int> naviY = gameboard.GetNaviY();

            int ponorky = 3;
            int ponorkyCount = 3;
            int torpedoborce = 2;
            int torpedoborceCount = 2;
            int krizniky = 1;
            int kriznikyCount = 1;
            int bitevnilode = 0;
            int bitevnilodeCount = 0;

            int pocetlodi = ponorkyCount + torpedoborce + krizniky + bitevnilode;

            while (pocetlodi > 0)
            {
                bool add = true;
                /*List<int> naviX = new List<int>();
                List<int> naviY = new List<int>();*/
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
                                naviY.Add(0);

                                
                                add = true;
                                
                                Console.Clear();

                                foreach (Ship lod in gameShips)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"ships in list posX{lod.posX[0]} posY{lod.posY[0]}");
                                    Console.ReadLine();
                                }
                                Console.WriteLine($"Rozmisěte {ponorkyCount} ponorek");
                                gameboard.GameBoardShow();
                                foreach (Ship lod in gameShips)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"ships in list posX{lod.posX[0]} posY{lod.posY[0]}");
                                    Console.ReadLine();
                                }
                                Console.ReadLine();
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
                                                    Console.WriteLine($"ship add false posX{lod.posX[0]} posY{lod.posY[0]} --- naviX{naviX[o]} naviY{naviY[o]}");
                                                    Console.ReadLine();
                                                    add = false;
                                                    i--;
                                                }
                                            }
                                        }
                                    }
                                }

                                if (add == true)
                                {
                                    Console.WriteLine($"ship added on x{gameboard.GetNaviX()[0]} y{gameboard.GetNaviY()[0]}");
                                    Console.ReadLine();
                                    gameShips.Add(new Ship
                                    {
                                        type = "Ponorka",
                                        posX = gameboard.GetNaviX(), //problém s ukládáním pozice přes naviX a naviY
                                        posY = gameboard.GetNaviY()
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
                                naviX.Add(1);
                                naviY.Add(0);
                                add = true;
                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {torpedoborceCount} torpedoborce");
                                gameboard.GameBoardShow();

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
                else if (selectedMenuIndex == 2)
                {
                    if (kriznikyCount > 0)
                    {
                        for (int i = 0; i < krizniky; i++)
                        {
                            if (kriznikyCount > 0)
                            {
                                naviX.Clear();
                                naviY.Clear();
                                naviX.Add(0);
                                naviX.Add(1);
                                naviX.Add(2);
                                naviY.Add(0);
                                add = true;
                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {kriznikyCount} krizniky");
                                gameboard.GameBoardShow();

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
                                        type = "Kriznik",
                                        posX = naviX,
                                        posY = naviY
                                    });
                                    kriznikyCount--;
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
                        Console.WriteLine("Došli ti krizniky");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }








            }
        }
    }
}
