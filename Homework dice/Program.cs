
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int number = 0;

            Console.Write("");
            int size = int.Parse(Console.ReadLine());

            number = dice.RollDice(size);
            Console.WriteLine( number);

            Console.ReadLine();
        }
    }
}