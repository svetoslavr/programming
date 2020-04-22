using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        Random number = new Random();
        public int RollDice(int size)
        {
            int nums = number.Next(1, size + 1);
            return nums;
        }
    }
}