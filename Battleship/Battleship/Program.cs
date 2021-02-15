using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {

            Submarine boat = new Submarine();
            Console.WriteLine(boat.type);
            Destroyer ship = new Destroyer();
            Console.WriteLine(ship.type);

            Console.ReadLine();

        }
    }
}
