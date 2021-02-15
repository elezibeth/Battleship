using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Carrier : MarineVessel
    {

        public int length;

        public char[,] carrier;

        public Destroyer()

        {
            length = 5;


            type = "carrierr";
            CreateVessel();




        }


        public void CreateVessel()
        {
            {
                char[,] carrier = new char[2, 1];


            }

        }
    }
}
