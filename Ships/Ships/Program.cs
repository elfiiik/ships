using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            Menu menu = new Menu();
            bool game = true;
            //GameBoard gameboard = new GameBoard();

            Console.WriteLine("Player 1:");
            Console.ReadLine();
            menu.MenuGenerate(1);
 
            Console.WriteLine("Player 2:");
            Console.ReadLine();
            menu.MenuGenerate(2);

            while (game)
            {
                game = false;
                menu.gameboard.GameMap(1);
                foreach(Ship lod2 in menu.gameboard.Ships2())
                {
                    if(lod2.hp < 1)
                    {
                        game = false;
                    } else { game = true; }
                }
                if(game=false)
                {
                    Console.Clear();
                    Console.WriteLine("Player 1 vyhrál!");
                    Console.ReadLine();
                    break;
                }
                game = false;
                menu.gameboard.GameMap(2);
                foreach (Ship lod1 in menu.gameboard.Ships1())
                {
                    if (lod1.hp < 1)
                    {
                        game = false;
                    } else { game = true; }
                }
                if (game=false)
                {
                    Console.Clear();
                    Console.WriteLine("Player 2 vyhrál!");
                    Console.ReadLine();
                    break;
                }
            }

            //gameboard.GameBoardShow();

        }
    }
}
