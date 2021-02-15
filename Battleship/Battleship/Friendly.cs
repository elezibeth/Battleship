using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Friendly : GameBoard
    {
        public Submarine sub;
        public Destroyer destroyer;

        //ctor
        public Friendly()
        {
            InstantiateShips();

        }

        //methods

        public void InstantiateShips()
        {
            sub = new Submarine();
            destroyer = new Destroyer();

        }
    }
}
