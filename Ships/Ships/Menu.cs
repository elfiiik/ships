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

        

        public void MenuGenerate()
        {
            
            GameBoard gameboard = new GameBoard();
            List<Ship> gameShips = gameboard.Ships();
            List<int> naviX = gameboard.GetNaviX();
            List<int> naviY = gameboard.GetNaviY();

            int ponorky = 3;
            int ponorkyCount = 3;
            int torpedoborce = 1;
            int torpedoborceCount = 1;
            int krizniky = 1;
            int kriznikyCount = 1;
            int bitevnilode = 0;
            int bitevnilodeCount = 0;
            int hydroplan = 2;
            int hydroplanCount = 2;

            int pocetlodi = ponorkyCount + torpedoborce + krizniky + bitevnilode;

            while (pocetlodi > 0)
            {
                bool add = true;
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
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x=1,
                                    y=0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 1
                                });

                                add = true;
                                
                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {ponorkyCount} ponorek");
                                gameboard.GameBoardShow();
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
                                                    Console.WriteLine($"Pozice je obsazena");
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
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Ponorka",
                                        pos = new List<Point>() { gameboard.GetNavi()[0]}
                                    });

                                    ponorkyCount--;


                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {
                                        
                                        foreach (Point policko in gameboard.GetGameBoard())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                Console.ReadLine();
                                                policko.ship = true;
                                            }
                                        }   
                                    }


                                }
                            }
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

                /*else if (selectedMenuIndex == 1)
                {
                    if (torpedoborceCount > 0)
                    {

                        for (int i = 0; i < torpedoborce; i++)
                        {
                            if (torpedoborceCount > 0)
                            {
                                gameboard.GetNaviX().Clear();
                                gameboard.GetNaviY().Clear();
                                gameboard.GetNaviX().Add(0);
                                gameboard.GetNaviX().Add(1);
                                gameboard.GetNaviY().Add(0);
                                add = true;

                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {torpedoborceCount} ponorek");
                                gameboard.GameBoardShow();
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
                                                    Console.WriteLine($"Pozice je obsazena");
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
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Torpedoborec",
                                        posX = new List<int>() { gameboard.GetNaviX()[0] , gameboard.GetNaviX()[1] },
                                        posY = new List<int>() { gameboard.GetNaviY()[0] }
                                    });

                                    torpedoborceCount--;
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

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti torpedoborce");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }*/

                else if (selectedMenuIndex == 1)
                {
                    if (torpedoborceCount > 0)
                    {

                        for (int i = 0; i < torpedoborce; i++)
                        {
                            if (torpedoborceCount > 0)
                            {
                                gameboard.GetNaviX().Clear();
                                gameboard.GetNaviY().Clear();
                                gameboard.GetNaviX().Add(0);
                                gameboard.GetNaviX().Add(1);
                                gameboard.GetNaviY().Add(0);
                                add = true;

                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {torpedoborceCount} ponorek");
                                gameboard.GameBoardShow();
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
                                                    Console.WriteLine($"Pozice je obsazena");
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
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Torpedoborec",
                                        posX = new List<int>() { gameboard.GetNaviX()[0], gameboard.GetNaviX()[1] },
                                        posY = new List<int>() { gameboard.GetNaviY()[0] }
                                    });

                                    torpedoborceCount--;
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

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti torpedoborce");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }


                else if (selectedMenuIndex == 6)
                {
                    if (hydroplanCount > 0)
                    {

                        for (int i = 0; i < hydroplan; i++)
                        {
                            if (hydroplanCount > 0)
                            {
                                gameboard.GetNaviX().Clear();
                                gameboard.GetNaviY().Clear();
                                gameboard.GetNaviX().Add(1);
                                gameboard.GetNaviX().Add(0);
                                gameboard.GetNaviX().Add(2);
                                gameboard.GetNaviY().Add(0);
                                gameboard.GetNaviY().Add(1);
                                add = true;

                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {hydroplanCount} hydroplanu");
                                gameboard.GameBoardShow();
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
                                                    Console.WriteLine($"Pozice je obsazena");
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
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Hydroplan",
                                        posX = new List<int>() { gameboard.GetNaviX()[0] },
                                        posY = new List<int>() { gameboard.GetNaviY()[0], gameboard.GetNaviY()[1] }
                                    });

                                    hydroplanCount--;
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

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti hydroplany");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }









            }
        }
    }
}
