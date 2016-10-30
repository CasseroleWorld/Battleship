using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Coordinate
    {
        public String Gfx = ".";
        public int index;


        public void CheckAdjacency(int loc1, int loc2)
        {

            Boolean bAdjacent;
            if (loc1 == loc2 + 1 || loc1 == loc2 - 1)
                bAdjacent = true;
            else if (loc1 == loc2 + 10 || loc1 == loc2 - 10)
                bAdjacent = true;
            else
                bAdjacent = false;
        }


    }
}
