using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    abstract class Player
    {

        //member variables

        public string name;
        public List<MarineVessel> fleet;
        public GameBoard friendly;
        public GameBoard enemy;


        //ctor
        public Player()
        {
            //method get hame
            name = GetNameOfPlayer();


        }

        //get name
        public void GetNameOfPlayer()
        {
            Console.WriteLine("please enter your name.");
            Console.ReadLine();
        }

        //methods

        //instantiate fleet's ships
        

        //add ships to fleet list

        //instantiate enemy game board tracker for turns

        //instantiate home game board

        //distribute fleet on home game board



    }
}
