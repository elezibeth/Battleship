using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Battleship : MarineVessel
    {

        public int length;

        public char[,] destroyer;

        public Destroyer()

        {
            length = 4;


            type = "battleship";
            CreateVessel();




        }


        public void CreateVessel()
        {
            {
                char[,] battleship = new char[2, 1];


            }

        }
    }
}
