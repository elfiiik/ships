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

            GameBoard gameboard = new GameBoard();


            Menu.MenuGenerate();

            GameBoard.GameBoardShow();

        }
    }
}
