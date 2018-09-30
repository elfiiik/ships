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
        public bool CheckCollision(int player)
        {
            bool add = true;
            if (player == 1)
            {
                for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                {
                    foreach (Point policko in gameboard.GetGameBoard1())
                    {
                        if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                        {
                            if (policko.ship)
                            {
                                add = false;
                            }
                            else
                            {
                                foreach (Ship lod in gameboard.Ships1())
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
            }
            if (player == 2)
            {
                for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                {
                    foreach (Point policko in gameboard.GetGameBoard2())
                    {
                        if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                        {
                            if (policko.ship)
                            {
                                add = false;
                            }
                            else
                            {
                                foreach (Ship lod in gameboard.Ships2())
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
            }
            return add;
        }




        public void MenuGenerate(int player)
        {
            List<Ship> gameShips1 = gameboard.Ships1();
            List<Ship> gameShips2 = gameboard.Ships2();

            List<int> naviX = gameboard.GetNaviX();
            List<int> naviY = gameboard.GetNaviY();


            int ponorky = 2;
            int ponorkyCount = 2;
            int torpedoborce = 2;
            int torpedoborceCount = 2;
            int krizniky = 2;
            int kriznikyCount = 2;
            int bitevnilode = 2;
            int bitevnilodeCount = 2;
            int letadlovelode = 1;
            int letadlovelodeCount = 1;
            int pristavacizakladny = 1;
            int pristavacizakladnyCount = 1;
            int hydroplany =1;
            int hydroplanyCount = 1;
            int krizniky2 = 1;
            int krizniky2Count = 1;
            int tezkekrizniky = 1;
            int tezkekriznikyCount = 1;
            int katamarany = 1;
            int katamaranyCount = 1;
            int lehkebitevnilode = 1;
            int lehkebitevnilodeCount = 1;
            int letadlovelode2 = 1;
            int letadlovelode2Count = 1;

            int pocetlodi = ponorkyCount + torpedoborceCount + kriznikyCount + bitevnilodeCount + letadlovelodeCount + pristavacizakladnyCount + hydroplanyCount + krizniky2Count +
                        tezkekriznikyCount + katamaranyCount + lehkebitevnilodeCount + letadlovelode2Count;

            while (pocetlodi > 0)
            {
                pocetlodi = ponorkyCount + torpedoborceCount + kriznikyCount + bitevnilodeCount + letadlovelodeCount + pristavacizakladnyCount + hydroplanyCount + krizniky2Count +
                        tezkekriznikyCount + katamaranyCount + lehkebitevnilodeCount + letadlovelode2Count;
                bool add = true;
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
                                    x = 0,
                                    y = 0
                                });

                                add = true;

                                Console.Clear();

                                Console.WriteLine($"Rozmisěte {ponorkyCount} ponorek");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Ponorka");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Ponorka");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }


                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Ponorka",
                                        pos = new List<Point>() { gameboard.GetNavi()[0] },
                                        hp = 1
                                    });

                                    ponorkyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if(add == true && player==2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Ponorka",
                                        pos = new List<Point>() { gameboard.GetNavi()[0] },
                                        hp = 1
                                    });

                                    ponorkyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Torpedoborec");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Torpedoborec");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }
                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Torpedoborec",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1] },
                                        hp = 2
                                    });

                                    torpedoborceCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Torpedoborec",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1] },
                                        hp = 2
                                    });

                                    torpedoborceCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Kriznik");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Kriznik");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }
                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Kriznik",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2] },
                                        hp = 3
                                    });

                                    kriznikyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Kriznik",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2] },
                                        hp = 3
                                    });

                                    kriznikyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                        for (int i = 0; i < bitevnilode; i++)
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
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Bitevni_lod");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Bitevni_lod");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }

                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Bitevni_lod",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3] },
                                        hp = 4
                                    });

                                    bitevnilodeCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Bitevni_lod",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3] },
                                        hp = 4
                                    });

                                    bitevnilodeCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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


                else if (selectedMenuIndex == 4)
                {
                    if (letadlovelodeCount > 0)
                    {
                        for (int i = 0; i < letadlovelode; i++)
                        {
                            if (letadlovelodeCount > 0)
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
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 4,
                                    y = 0
                                });

                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {letadlovelodeCount} letadlové lodě");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Letadlova_lod");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Letadlova_lod");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }
                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Letadlova_lod",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4] },
                                        hp = 5
                                    });

                                    letadlovelodeCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Letadlova_lod",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4] },
                                        hp = 5
                                    });

                                    letadlovelodeCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                        Console.WriteLine("Došli ti letadlove lode");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (selectedMenuIndex == 5)
                {
                    if (pristavacizakladnyCount > 0)
                    {
                        for (int i = 0; i < pristavacizakladny; i++)
                        {
                            if (pristavacizakladnyCount > 0)
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
                                    x = 0,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 1
                                });

                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {pristavacizakladnyCount} přistávací základny");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Pristavaci_zakladna");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Pristavaci_zakladna");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }

                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Pristavaci_zakladna",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2],
                                                                gameboard.GetNavi()[3], gameboard.GetNavi()[4], gameboard.GetNavi()[5] },
                                        hp = 6
                                    });

                                    pristavacizakladnyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Pristavaci_zakladna",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2],
                                                                gameboard.GetNavi()[3], gameboard.GetNavi()[4], gameboard.GetNavi()[5] },
                                        hp = 6
                                    });

                                    pristavacizakladnyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                        Console.WriteLine("Došli ti pristavaci zakladny");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (selectedMenuIndex == 6)
                {
                    if (hydroplanyCount > 0)
                    {
                        for (int i = 0; i < hydroplany; i++)
                        {
                            if (hydroplany> 0)
                            {
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 0
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
                                Console.WriteLine($"Rozmisěte {hydroplanyCount} hydroplány");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Hydroplan");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Hydroplan");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }

                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Hydroplan",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], },
                                        hp = 3
                                    });

                                    hydroplanyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Hydroplan",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], },
                                        hp = 3
                                    });

                                    hydroplanyCount--;
                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                        Console.WriteLine("Došli ti hydroplany");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }


                else if (selectedMenuIndex == 7)
                {
                    if (krizniky2Count > 0)
                    {
                        for (int i = 0; i < krizniky2; i++)
                        {
                            if (krizniky2Count > 0)
                            {
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 1
                                });
                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {krizniky2Count} křižníky2");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Kriznik2");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Kriznik2");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }

                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Kriznik2",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3] },
                                        hp = 4
                                    });

                                    krizniky2Count--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Kriznik2",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3] },
                                        hp = 4
                                    });

                                    krizniky2Count--;
                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                        Console.WriteLine("Došli ti krizniky2");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (selectedMenuIndex == 8)
                {
                    if (tezkekriznikyCount > 0)
                    {
                        for (int i = 0; i < tezkekrizniky; i++)
                        {
                            if (tezkekriznikyCount > 0)
                            {
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 2
                                });
                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {tezkekriznikyCount} těžké křižníky");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Tezky_kriznik");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Tezky_kriznik");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }

                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Tezky_kriznik",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4] },
                                        hp = 5
                                    });

                                    tezkekriznikyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Tezky_kriznik",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4] },
                                        hp = 5
                                    });

                                    tezkekriznikyCount--;
                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                        Console.WriteLine("Došli ti těžké křižníky");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (selectedMenuIndex == 9)
                {
                    if (katamaranyCount > 0)
                    {
                        for (int i = 0; i < katamarany; i++)
                        {
                            if (katamaranyCount > 0)
                            {
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 2
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 2
                                });
                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {katamaranyCount} katamarany");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Katamaran");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Katamaran");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }

                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Katamaran",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4],
                                                                gameboard.GetNavi()[5],gameboard.GetNavi()[6]},
                                        hp = 7
                                    });

                                    katamaranyCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Katamaran",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4],
                                                                gameboard.GetNavi()[5],gameboard.GetNavi()[6]},
                                        hp = 7
                                    });

                                    katamaranyCount--;
                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                        Console.WriteLine("Došli ti katamarany");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (selectedMenuIndex == 10)
                {
                    if (lehkebitevnilodeCount > 0)
                    {
                        for (int i = 0; i < lehkebitevnilode; i++)
                        {
                            if (lehkebitevnilodeCount > 0)
                            {
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 1
                                });
                                
                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {lehkebitevnilodeCount} lehké bitevní lodě");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Lehka_bitevni_lod");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Lehka_bitevni_lod");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }

                                if (add == true && player == 1)
                                {
                                    gameboard.Ships1().Add(new Ship
                                    {
                                        type = "Lehka_bitevni_lod",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2] },
                                        hp = 3
                                    });

                                    lehkebitevnilodeCount--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Lehka_bitevni_lod",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2] },
                                        hp = 3
                                    });

                                    lehkebitevnilodeCount--;
                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
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
                        Console.WriteLine("Došli ti lehké bitevní lodě");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (selectedMenuIndex == 11)
                {
                    if (letadlovelode2Count > 0)
                    {
                        for (int i = 0; i < letadlovelode2; i++)
                        {
                            if (letadlovelode2Count > 0)
                            {
                                gameboard.GetNavi().Clear();
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 3,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 4,
                                    y = 0
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 0,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 1,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 2,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 3,
                                    y = 1
                                });
                                gameboard.GetNavi().Add(new Point
                                {
                                    x = 4,
                                    y = 1
                                });
                                add = true;
                                Console.Clear();
                                Console.WriteLine($"Rozmisěte {letadlovelode2Count} letadlové lodě2");
                                if (player == 1)
                                {
                                    gameboard.GameBoardShow1("Letadlova_lod2");
                                    Console.ReadLine();
                                    if (gameShips1.Count() != 0)
                                    {
                                        add = CheckCollision(1);

                                    }
                                }
                                else if (player == 2)
                                {
                                    gameboard.GameBoardShow2("Letadlova_lod'2");
                                    Console.ReadLine();
                                    if (gameShips2.Count() != 0)
                                    {
                                        add = CheckCollision(2);

                                    }
                                }

                                if (add == true && player == 1)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Letadlova_lod2",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4],
                                                                gameboard.GetNavi()[5],gameboard.GetNavi()[6]},
                                        hp = 7
                                    });

                                    letadlovelode2Count--;

                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard1())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else if (add == true && player == 2)
                                {
                                    gameboard.Ships2().Add(new Ship
                                    {
                                        type = "Letadlova_lod2",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4],
                                                                gameboard.GetNavi()[5],gameboard.GetNavi()[6]},
                                        hp = 7
                                    });

                                    letadlovelode2Count--;
                                    for (int j = 0; j < gameboard.GetNavi().Count(); j++)
                                    {

                                        foreach (Point policko in gameboard.GetGameBoard2())
                                        {
                                            if (gameboard.GetNavi()[j].x == policko.x && gameboard.GetNavi()[j].y == policko.y)
                                            {
                                                policko.ship = true;

                                            }
                                        }
                                    }
                                }
                                else { i--; }

                                /*if (add == true)
                                {
                                    gameboard.Ships().Add(new Ship
                                    {
                                        type = "Letadlova_lod2",
                                        pos = new List<Point>() { gameboard.GetNavi()[0], gameboard.GetNavi()[1], gameboard.GetNavi()[2], gameboard.GetNavi()[3], gameboard.GetNavi()[4],
                                                                gameboard.GetNavi()[5],gameboard.GetNavi()[6]}
                                    });

                                    letadlovelode2Count--;
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
                                else { i--; }*/

                            }
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti letadlové lodě2");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }









            }
        }
    }
}
