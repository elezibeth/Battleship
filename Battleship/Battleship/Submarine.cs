using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Submarine : MarineVessel
    {
        public int length;

        public char[,] submarine;

        public Submarine()
            
        {
            length = 3;

            
            type = "submarine";
            CreateVessel();
            
        }


        public void CreateVessel()
        {
            {
                char[,] submarine = new char[length, width];

            }

        }



    }
}
