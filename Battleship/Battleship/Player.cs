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

        public string playerName;
        public EnemyFleet enemyBoard;
        public Friendly friendlyBoard;
        public bool turn;
        public Friendly friendly;


        //ctor
        public Player()
        {
            //method get hame
            GetNameOfPlayer();
            turn = false;
            friendlyBoard = new Friendly();
            enemyBoard = new EnemyFleet();
            


        }

        //get name
        public void GetNameOfPlayer()
        {
            Console.WriteLine("please enter your name.");
            playerName = Console.ReadLine();
        
        
        }

        //methods
        

        
       


        
        
        


        

        //instantiate enemy game board tracker for turns

        //instantiate home game board

        //distribute fleet on home game board



    }
}
