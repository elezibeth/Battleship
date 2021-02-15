using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class MarineVessel
    {
        //members
        public int length;
        public int width;
        public int[,] arr2d;
        public string type;


        //ctor
        public MarineVessel(int length)
        {
            this.length = length;
            width = 1;
            CreateVessel(length, width);
            type = DetermineType(length);


        }

        //methods
        public void CreateVessel(int length, int width)
        {
            int[,] arr2d = new int[length, width];

        }

        public string DetermineType(int length)
        {
            if(length == 2)
            {
                return "Destroyer";
            }
            else if(length == 3)
            {
                return "submarin";
            }
            else if(length == 4)
            {
                return "BattleShip";
            }
            else if(length == 5)
            {
                return "Aircraft Carrier";
            }
            else
            {
                return "Not a real boat";
            }

            
            

        }


    }
}
