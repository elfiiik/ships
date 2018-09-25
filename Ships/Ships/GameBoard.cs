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
        public int naviX = 0;
        public int naviY = 0;
        private List<Point> GameBoardGenerate()
        {
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
            return pole;
        }

        public void GameBoardShow()
        {
            
            //Vypisování GameBoard a navigace po ní
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
                    if (naviY < width - 1) { naviY++; }
                }
                else if (navigation.Key == ConsoleKey.Enter)
                {
                    tryAdd = true;
                }
                Console.Clear();
                Console.WriteLine();

                List<Point> gameboardgen = GameBoardGenerate();
                foreach (Point point in gameboardgen)
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
        }


    }
}
