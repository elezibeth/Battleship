using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Destroyer : MarineVessel
    {

        public int length;

        public char[,] destroyer;

        public Destroyer()

        {
            length = 2;


            type = "destroyer";
            CreateVessel();
            

            

        }


        public void CreateVessel()
        {
            {
                char[,] destroyer = new char[2, 1];
                

            }

        }
       






    }
}
