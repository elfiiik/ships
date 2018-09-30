using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class GameBoard
    {
        private static int width = 20;
        private static int height = 20;
        /*public int naviX = 0;
        public int naviY = 0;*/
        private List<Point> gameBoardMap1 = new List<Point>();
        private List<Point> gameBoardMap2 = new List<Point>();
        public GameBoard()
        {
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
                    gameBoardMap1.Add(new Point
                    {
                        x = j,
                        y = i,
                        radek = radek1
                    });
                    gameBoardMap2.Add(new Point
                    {
                        x = j,
                        y = i,
                        radek = radek1
                    });
                }
            }
        }


        public void ShipRotate(string type,int rot)
        {
            switch(type)
            {               
                case "Torpedoborec":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                    }
                break;

                case "Kriznik":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });

                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            break;
                    }
                    break;

                case "Bitevni_lod":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });

                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 6
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 5
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 6,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 5,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            break;
                    }
                    break;

                case "Letadlova_lod":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 4
                            });

                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 8
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 7
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 6
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 5
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 4
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 8,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 7,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 6,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 5,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 4
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 4
                            });
                            break;
                    }
                    break;

                case "Pristavaci_zakladna":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 3
                            });

                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 4
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 3
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 0
                            });
                            break;
                    }
                    break;
                case "Hydroplan":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });

                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            break;
                    }
                    break;

                case "Kriznik2":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });

                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                    }
                    break;

                case "Katamaran":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });

                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 2
                            });
                            break;
                    }
                    break;

                case "Lehka_bitevni_lod":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 0
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 1
                            });
                            break;
                    }
                    break;

                case "Letadlova_lod2":
                    switch (rot)
                    {
                        case 1:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 2,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 1,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 0,
                                y = 4
                            });

                            break;
                        case 2:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 5
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 6
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 7
                            });
                            break;
                        case 3:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 5,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 6,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 7,
                                y = 3
                            });
                            break;
                        case 4:
                            GetNavi().Clear();
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 3
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 4,
                                y = 4
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 2
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 1
                            });
                            GetNavi().Add(new Point
                            {
                                x = 3,
                                y = 0
                            });
                            break;
                    }
                    break;
            }
        }

        public List<Point> GetGameBoard1()
        {
            return gameBoardMap1;
        }

        public List<Point> GetGameBoard2()
        {
            return gameBoardMap2;
        }


        private List<int> naviX = new List<int>();
        public List<int> GetNaviX()
        {
            return naviX;
        }

        private List<int> naviY = new List<int>();
        public List<int> GetNaviY()
        {
            return naviY;
        }

        private List<Point> navi = new List<Point>();
        public List<Point> GetNavi()
        {
            return navi;
        }

        private List<Ship> ship1 = new List<Ship>();
        public List<Ship> Ships1()
        {
            return ship1;
        }

        private List<Ship> ship2 = new List<Ship>();
        public List<Ship> Ships2()
        {
            return ship2;
        }


        public void GameBoardShow1(string shiptype)
        {
            //Vypisování GameBoard a navigace po ní
            bool hmm = true;
            int rotate = 1;

            while (hmm)
            {
                /*foreach (Point bod in navi)
                {
                    Console.WriteLine($"bod x{bod.x} y{bod.y}");
                }*/
                bool tryAdd = false;
                bool zvetsit = true;
                ConsoleKeyInfo navigation = Console.ReadKey();
                if (navigation.Key == ConsoleKey.RightArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.x >= width - 1)
                        {
                            zvetsit = false;
                        }
                    }
                    foreach (Point navig in navi)
                    {
                        if (zvetsit) { navig.x++; }
                    }

                }
                else if (navigation.Key == ConsoleKey.LeftArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.x < 1)
                        {
                            zvetsit = false;
                        }
                    }
                    foreach (Point navig in navi)
                    {
                        if (zvetsit) { navig.x--; }
                    }
                }
                else if (navigation.Key == ConsoleKey.UpArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.y < 1)
                        {
                            zvetsit = false;
                        }
                    }
                    foreach (Point navig in navi)
                    {
                        if (zvetsit) { navig.y--; }
                    }
                }
                else if (navigation.Key == ConsoleKey.DownArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.y >= height - 1)
                        {
                            zvetsit = false;
                        }
                    }
                    foreach (Point navig in navi)
                    {
                        if (zvetsit) { navig.y++; }
                    }
                }
                else if (navigation.Key == ConsoleKey.Enter)
                {
                    tryAdd = true;
                }
                else if (navigation.Key == ConsoleKey.R)
                {
                    rotate++;
                    if (rotate == 5)
                    {
                        rotate = 1;
                    }

                    ShipRotate(shiptype, rotate);
                }


                Console.Clear();

       
                List<int> addX = new List<int>();
                List<int> addY = new List<int>();
                addX.Clear();
                addY.Clear();
                foreach (Point point in gameBoardMap1)
                {
                    foreach (Point navigace in navi)
                    {
                        if (point.x == navigace.x && point.y == navigace.y)
                        {                
                            addX.Add(navigace.x);
                            addY.Add(navigace.y);
                        }
                        
                    }

                }

                for (int i = 0; i < width * height; i++)
                {
                    if (tryAdd)
                    {
                        hmm = false;                        
                    }

                    bool addelse = true;

                    for(int j=0; j<addX.Count();j++)
                    {
                        if (addX[j] == gameBoardMap1[i].x && addY[j]== gameBoardMap1[i].y)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                            addelse = false;
                        }
                    }
                        
                    if (addelse && gameBoardMap1[i].ship)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("*");
                    }
                    else if(addelse)
                    {
                        Console.Write("*");
                    }
                    if (gameBoardMap1[i].radek)
                    {
                        Console.WriteLine();
                    }
                    Console.ResetColor();
                }
            }         
        }

        public void GameBoardShow2(string shiptype)
        {
            //Vypisování GameBoard a navigace po ní
            bool hmm = true;
            int rotate = 1;

            while (hmm)
            {
                /*foreach (Point bod in navi)
                {
                    Console.WriteLine($"bod x{bod.x} y{bod.y}");
                }*/
                bool tryAdd = false;
                bool zvetsit = true;
                ConsoleKeyInfo navigation = Console.ReadKey();
                if (navigation.Key == ConsoleKey.RightArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.x >= width - 1)
                        {
                            zvetsit = false;
                        }
                    }
                    foreach (Point navig in navi)
                    {
                        if (zvetsit) { navig.x++; }
                    }

                }
                else if (navigation.Key == ConsoleKey.LeftArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.x < 1)
                        {
                            zvetsit = false;
                        }
                    }
                    foreach (Point navig in navi)
                    {
                        if (zvetsit) { navig.x--; }
                    }
                }
                else if (navigation.Key == ConsoleKey.UpArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.y < 1)
                        {
                            zvetsit = false;
                        }
                    }
                    foreach (Point navig in navi)
                    {
                        if (zvetsit) { navig.y--; }
                    }
                }
                else if (navigation.Key == ConsoleKey.DownArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.y >= height - 1)
                        {
                            zvetsit = false;
                        }
                    }
                    foreach (Point navig in navi)
                    {
                        if (zvetsit) { navig.y++; }
                    }
                }
                else if (navigation.Key == ConsoleKey.Enter)
                {
                    tryAdd = true;
                }
                else if (navigation.Key == ConsoleKey.R)
                {
                    rotate++;
                    if (rotate == 5)
                    {
                        rotate = 1;
                    }

                    ShipRotate(shiptype, rotate);
                }


                Console.Clear();


                List<int> addX = new List<int>();
                List<int> addY = new List<int>();
                addX.Clear();
                addY.Clear();
                foreach (Point point in gameBoardMap2)
                {
                    foreach (Point navigace in navi)
                    {
                        if (point.x == navigace.x && point.y == navigace.y)
                        {
                            addX.Add(navigace.x);
                            addY.Add(navigace.y);
                        }

                    }

                }

                for (int i = 0; i < width * height; i++)
                {
                    if (tryAdd)
                    {
                        hmm = false;
                    }

                    bool addelse = true;

                    for (int j = 0; j < addX.Count(); j++)
                    {
                        if (addX[j] == gameBoardMap2[i].x && addY[j] == gameBoardMap2[i].y)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                            addelse = false;
                        }
                    }

                    if (addelse && gameBoardMap2[i].ship)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("*");
                    }
                    else if (addelse)
                    {
                        Console.Write("*");
                    }
                    if (gameBoardMap2[i].radek)
                    {
                        Console.WriteLine();
                    }
                    Console.ResetColor();
                }
            }
        }


        public void GameMap(int player)
        {
            int navX = 0;
            int navY = 0;
            bool cykl = true;
            bool zasah = false;
            bool kill = false;
            bool missed = false;
            bool stop1 = false;
            bool stop2 = false;
            while (cykl)
            {
                foreach (Ship lod1 in Ships1())
                {
                    if (lod1.hp < 1)
                    {
                        stop1 = true;
                    }
                    else { stop1 = false; }
                }

                foreach (Ship lod2 in Ships2())
                {
                    if (lod2.hp < 1)
                    {
                        stop2 = true;
                    }
                    else { stop2 = false; }
                }

                if (stop1 || stop2)
                {
                    cykl = false;
                    break;
                }

                if (player == 1)
                {
                    Console.WriteLine("Player 1:");
                }
                else if (player == 2)
                {
                    Console.WriteLine("Player 2:");
                }

                if (zasah)
                {
                    Console.WriteLine("Zásah! Střílej znova");
                }
                else if (kill)
                {
                    Console.WriteLine($"Potopil si nepřátelskou loď! Střílej znova");
                }
                bool tryAttack = false;
                ConsoleKeyInfo navigation = Console.ReadKey();
                if (navigation.Key == ConsoleKey.RightArrow)
                {
                    if (navX < width - 1) { navX++; }
                }
                else if (navigation.Key == ConsoleKey.LeftArrow)
                {
                    if (navX >= 1) { navX--; }
                }
                else if (navigation.Key == ConsoleKey.UpArrow)
                {
                    if (navY >= 1) { navY--; }
                }
                else if (navigation.Key == ConsoleKey.DownArrow)
                {
                    if (navY < height - 1) { navY++; }
                }
                else if (navigation.Key == ConsoleKey.Enter)
                {
                    tryAttack = true;
                }

                Console.Clear();
                
                if (player == 1)
                {
                    foreach (Point point in gameBoardMap2)
                    {
                        if (tryAttack && navX == point.x && navY == point.y && point.hit == false && point.miss == false)
                        {
                            if (point.ship)
                            {
                                point.hit = true;
                                foreach (Ship lod2 in Ships2())
                                {
                                    foreach (Point posi in lod2.pos)
                                    {
                                        if (posi.x == point.x && posi.y==point.y)
                                        {
                                            lod2.hp--;
                                            if(lod2.hp < 1)
                                            {
                                                kill = true;
                                                zasah = false;
                                            }
                                            else { zasah = true; kill = false; }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                point.miss = true;
                                cykl = false;
                                zasah = false;
                                kill = false;
                                Console.Clear();
                                Console.WriteLine("Netrefil ses, hraje Player 2");
                                Console.ReadLine();
                            }
                        }
                        if (navX==point.x && navY==point.y)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                        }
                        else if (point.hit == false && point.miss==false)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("*");
                        }
                        else if(point.hit)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write("*");
                        }
                        else if (point.miss)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("*");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("*");
                        }
                        if (point.radek)
                        {
                            Console.WriteLine();
                        }
                        Console.ResetColor();
                    }
                }

                else if (player == 2)
                {
                    foreach (Point point in gameBoardMap1)
                    {
                        if (tryAttack && navX == point.x && navY == point.y && point.hit == false && point.miss == false)
                        {
                            if (point.ship)
                            {
                                point.hit = true;
                                foreach (Ship lod1 in Ships1())
                                {
                                    foreach (Point posi in lod1.pos)
                                    {
                                        if (posi.x == point.x && posi.y == point.y)
                                        {
                                            lod1.hp--;
                                            if (lod1.hp < 1)
                                            {
                                                kill = true;
                                                zasah = false;
                                            }
                                            else { zasah = true; kill = false; }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                point.miss = true;
                                cykl = false;
                                zasah = false;
                                kill = false;
                                Console.Clear();
                                Console.WriteLine("Netrefil ses, hraje Player 1");
                                Console.ReadLine();
                            }
                        }
                        if (navX == point.x && navY == point.y)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                        }
                        else if (point.hit == false && point.miss == false)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("*");
                        }
                        else if (point.hit)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write("*");
                        }
                        else if (point.miss)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("*");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("*");
                        }
                        if (point.radek)
                        {
                            Console.WriteLine();
                        }
                        Console.ResetColor();
                    }
                }



            }
        }

    }
}
