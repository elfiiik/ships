using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Ship
    {
        /*public List<int> posX { get; set; }
        public List<int> posY { get; set; }*/
        public List<int> posX = new List<int>();
        public List<int> posY = new List<int>();
        public List<int> GetposX()
        {
            return posX;
        }
        public List<int> GetposY()
        {
            return posY;
        }

        public int x;
        public int y;
        public string type;

        

    }
}
