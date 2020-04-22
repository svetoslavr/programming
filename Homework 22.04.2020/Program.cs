
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice number = new Dice();
            int random = 0;

            Console.Write("");
            int dicenumber = int.Parse(Console.ReadLine());

            random = number.RollDice(dicenumber);
            Console.WriteLine( number);

            Console.ReadLine();
        }
    }
}