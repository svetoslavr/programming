using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int odds = 0, evens = 0;

            foreach (var number in array)
            {
                if (number % 2 == 0)
                {
                    odds += number;
                }
                else
                {
                    evens += evens;
                }
            }

            Console.WriteLine($"({evens}) - ({odds}) = {evens - odds}");
            Console.ReadLine();
        }

    }
}
