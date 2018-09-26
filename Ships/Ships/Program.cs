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
            GameBoard gameboard = new GameBoard();


            menu.MenuGenerate();

            //gameboard.GameBoardShow();

        }
    }
}
