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
        
        public GameBoard enemy;
       
        public bool turn;
        public Friendly friendly;


        //ctor
        public Player()
        {
            //method get hame
            GetNameOfPlayer();
            
            turn = false;
            friendly = new Friendly();


        }

        //get name
        public void GetNameOfPlayer()
        {
            Console.WriteLine("please enter your name.");
            name = Console.ReadLine();
        }

        //methods

        //instantiate fleet's ships
       


        //add ships to fleet list
        
        


        

        //instantiate enemy game board tracker for turns

        //instantiate home game board

        //distribute fleet on home game board



    }
}
