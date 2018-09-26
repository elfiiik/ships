using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Ship
    {
        public List<int> posX = new List<int>();
        public List<int> posY = new List<int>();
        //public List<int> posY { get; set; }

        public string type;

        /*public static void AddShip(string shipadd)
        {
            switch(shipadd)
            {
                case "ponorka":
                    ship.Add(new Ship
                    {
                        type = "Ponorka",
                        posX = new List<int>() { 0 },
                        posY = new List<int>() { 0 }
                    });
                    break;
            }
        }*/

        /*public static void addShip()
        {
            List<Ship> ship = new List<Ship>();
            Ship shiptest = new Ship();
            int selectedMenuShip = drawMenu();
            switch (selectedMenuShip)
            {
                case 0:
                    ship.Add(new Ship
                    {
                        type = "Ponorka",
                        posX = new List<int>() { 0 },
                        posY = new List<int>() { 0 }
                    });

                    break;
                default:
                    break;
            }
        }*/

    }
}
