using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {

        //members
        public Player playerOne;
        public Player playerTwo;

        //ctor
        public Game()
        {
            InstantiatePlayers();

        }

        //methods
        public void InstantiatePlayers()
        {

            playerOne = new Human();
            playerTwo = new Human();
            

        }
    }
}
