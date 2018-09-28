﻿using System;
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
        private List<Point> gameBoardMap = new List<Point>();
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
                    gameBoardMap.Add(new Point
                    {
                        x = j,
                        y = i,
                        radek = radek1
                    });
                }
            }
        }

        public List<Point> GetGameBoard()
        {
            return gameBoardMap;
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

        private List<Point> navi= new List<Point>();
        public List<Point> GetNavi()
        {
            return navi;
        }

        private List<Ship> ship = new List<Ship>();
        public List<Ship> Ships()
        {
            return ship;
        }

        public void GameBoardShow()
        {
            //Vypisování GameBoard a navigace po ní
            bool hmm = true;
            int maxX = navi.Max(x => x.x);
            while (hmm)
            {
                bool tryAdd = false;
                ConsoleKeyInfo navigation = Console.ReadKey();
                if (navigation.Key == ConsoleKey.RightArrow)
                {
                    if (maxX < width - 1)
                    {
                        foreach (Point navig in navi)
                        {
                            navig.x++;                       
                        }
                    }

                }
                else if (navigation.Key == ConsoleKey.LeftArrow)
                {
                    if (naviX.Min() > 0)
                    {
                        for (int i = 0; i < naviX.Count(); i++)
                        {
                            naviX[i]--;
                        }
                    }
                }
                else if (navigation.Key == ConsoleKey.UpArrow)
                {
                    if (naviY.Min() > 0)
                    {
                        for (int i = 0; i < naviY.Count(); i++)
                        {
                            naviY[i]--;
                        }
                    }
                }
                else if (navigation.Key == ConsoleKey.DownArrow)
                {
                    if (naviY.Max() < width - 1)
                    {
                        for (int i = 0; i < naviY.Count(); i++)
                        {
                            naviY[i]++;
                        }
                    }
                }
                else if (navigation.Key == ConsoleKey.Enter)
                {
                    tryAdd = true;
                }

                Console.Clear();



                foreach (Point point in gameBoardMap)
                {
                    if (tryAdd)
                    {
                        hmm = false;
                    }

                    foreach (Point navig in navi)
                    {
                        if (navig.x == point.x && navig.y == point.y)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("*");

                        }
                    }
                    
                    
                    
                    /*if (naviX.Contains(point.x) && naviY.Contains(point.y))
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("*");

                    }*/
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
            
        }


    }
}
