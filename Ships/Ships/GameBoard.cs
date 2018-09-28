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
            while (hmm)
            {
                foreach (Point bod in navi)
                {
                    Console.WriteLine($"bod x{bod.x} y{bod.y}");
                }
                
                bool tryAdd = false;
                bool zvetsit = true;
                ConsoleKeyInfo navigation = Console.ReadKey();
                if (navigation.Key == ConsoleKey.RightArrow)
                {
                    foreach (Point navig in navi)
                    {
                        if (navig.x >= width-1)
                        {
                            zvetsit = false;
                        }                                                            
                    }
                    foreach(Point navig in navi)
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


                Console.Clear();

       
                List<int> addX = new List<int>();
                List<int> addY = new List<int>();
                addX.Clear();
                addY.Clear();
                foreach (Point point in gameBoardMap)
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
                        if (addX[j] == gameBoardMap[i].x && addY[j]== gameBoardMap[i].y)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                            addelse = false;
                        }
                    }
                        
                    if (addelse && gameBoardMap[i].ship)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("*");
                    }
                    else if(addelse)
                    {
                        Console.Write("*");
                    }
                    if (gameBoardMap[i].radek)
                    {
                        Console.WriteLine();
                    }
                    Console.ResetColor();
                }
            }         
        }




    }
}
