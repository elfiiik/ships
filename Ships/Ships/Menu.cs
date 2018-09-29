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


        public GameBoard gameboard = new GameBoard();
        public bool CheckCollision()
        {
            bool add = true;
            for (int j = 0; j < gameboard.GetNavi().Count(); j++)
            {

                foreach (Point policko in gameboard.GetGameBoard())
                {
                    if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                    {
                        if (policko.ship)
                        {
                            add = false;
                        }
                        else
                        {
                            foreach (Ship lod in gameboard.Ships())
                            {
                                foreach (Point posi in lod.pos)
                                {
                                    if (gameboard.GetNavi()[j].x == posi.x - 1 && gameboard.GetNavi()[j].y == posi.y)
                                    {
                                        add = false;
                                    }
                                    else if (gameboard.GetNavi()[j].x == posi.x + 1 && gameboard.GetNavi()[j].y == posi.y)
                                    {
                                        add = false;
                                    }
                                    else if (gameboard.GetNavi()[j].y == posi.y + 1 && gameboard.GetNavi()[j].x == posi.x)
                                    {
                                        add = false;
                                    }
                                    else if (gameboard.GetNavi()[j].y == posi.y - 1 && gameboard.GetNavi()[j].x == posi.x)
                                    {
                                        add = false;
                                    }
                                    else if (gameboard.GetNavi()[j].y == posi.y - 1 && gameboard.GetNavi()[j].x == posi.x + 1)
                                    {
                                        add = false;
                                    }
                                    else if (gameboard.GetNavi()[j].y == posi.y - 1 && gameboard.GetNavi()[j].x == posi.x - 1)
                                    {
                                        add = false;
                                    }
                                    else if (gameboard.GetNavi()[j].x == posi.x + 1 && gameboard.GetNavi()[j].y == posi.y + 1)
                                    {
                                        add = false;
                                    }
                                    else if (gameboard.GetNavi()[j].x == posi.x - 1 && gameboard.GetNavi()[j].y == posi.y + 1)
                                    {
                                        add = false;
                                    }
                                }

                            }

                        }

                    }
                }
            }
            return add;
        }




        public void MenuGenerate()
        {
            
            List<Ship> gameShips = gameboard.Ships();
            List<int> naviX = gameboard.GetNaviX();
            List<int> naviY = gameboard.GetNaviY();

            int ponorky = 3;
            int ponorkyCount = 3;
            int torpedoborce = 3;
            int torpedoborceCount = 3;
            int krizniky = 2;
            int kriznikyCount = 2;
            int bitevnilode = 2;
            int bitevnilodeCount = 2;
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
                                   add = CheckCollision();

                                }

                                if (add == true)
                                {
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Ponorka",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1] , gameboard.GetNavi()[2] }
                                    });

                                    ponorkyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else{i--;}

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

                else if (selectedMenuIndex == 1)
                {
                    if (torpedoborceCount > 0)
                    {
                        for (int i = 0; i < torpedoborce; i++)
                        {
                            if (torpedoborceCount > 0)
                            {
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 0
                                });    

                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {torpedoborceCount} torpedoborce");
                                gameboard.GameBoardShow();
                                Console.ReadLine();
                                if (gameShips.Count() != 0)
                                {
                                    add = CheckCollision();
                                }

                                if (add == true)
                                {
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Torpedoborec",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1] }
                                    });

                                    torpedoborceCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;
                                            }
                                        }
                                    }
                                }
                                else { i--; }
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
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 0
                                });

                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {kriznikyCount} krizniky");
                                gameboard.GameBoardShow();
                                Console.ReadLine();
                                if (gameShips.Count() != 0)
                                {
                                    add = CheckCollision();

                                }

                                if (add == true)
                                {
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Kriznik",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2] }
                                    });

                                    kriznikyCount--;
                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;
                                            }
                                        }
                                    }
                                }
                                else { i--; }

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

                else if (selectedMenuIndex == 3)
                {
                    if (bitevnilodeCount > 0)
                    {
                        for (int i = 0; i < krizniky; i++)
                        {
                            if (bitevnilodeCount > 0)
                            {
                                gameboard.GetNavi().Clear(); 
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 3,
                                    y = 0
                                });

                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {bitevnilodeCount} bitevní lodě");
                                gameboard.GameBoardShow();
                                Console.ReadLine();
                                if (gameShips.Count() != 0)
                                {
                                    add = CheckCollision();
                                }

                                if (add == true)
                                {
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Bitevni_lod",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3] }
                                    });

                                    bitevnilodeCount--;
                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {
                                        foreach (Point policko in gameboard.GetGameBoard())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;
                                            }
                                        }
                                    }
                                }
                                else { i--; }

                            }
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti bitevni lode");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }









            }
        }
    }
}
