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
        public List<MarineVessel> fleet;
        public Battleship battleship;

        //ctor
        public Friendly()
        {
            InstantiateShips();
            AddShipsToFleet();

        }

        //methods

        public void InstantiateShips()
        {
            sub = new Submarine();
            destroyer = new Destroyer();
            battleship = new Battleship();
            

        }

        public void AddShipsToFleet()
        {
            fleet = new List<MarineVessel>();
            fleet.Add(sub);
            fleet.Add(destroyer);
            fleet.Add(battleship);
        }
    }
}
