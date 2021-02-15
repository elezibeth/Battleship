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

        public int[,] submarine;

        public Submarine()
            
        {
            length = 2;

            
            type = "submarine";
            CreateVessel();
            
        }


        public void CreateVessel()
        {
            {
                int[,] submarine = new int[length, width];

            }

        }



    }
}
