using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    abstract class GameBoard
    {   //member variables
        public char[,] grid;

        //ctor
        public GameBoard()
        {
            grid = new char[20, 20];
        }



        //methods



    }
}
