﻿using System;
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
        public Submarine sub;
        public Destroyer destroyer;
        public bool turn;


        //ctor
        public Player()
        {
            //method get hame
            GetNameOfPlayer();
            InstantiateShips();
            AddShipsToFleet();
            turn = false;


        }

        //get name
        public void GetNameOfPlayer()
        {
            Console.WriteLine("please enter your name.");
            name = Console.ReadLine();
        }

        //methods

        //instantiate fleet's ships
        public void InstantiateShips()
        {
            sub = new Submarine();
            destroyer = new Destroyer();

        }


        //add ships to fleet list
        public void AddShipsToFleet()
        {
            fleet = new List<MarineVessel>();
            fleet.Add(sub);
            fleet.Add(destroyer);
        }
        

        //instantiate enemy game board tracker for turns

        //instantiate home game board

        //distribute fleet on home game board



    }
}
