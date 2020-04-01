using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            int[,] array = new int[cols, rows];

            for (int a = 0; a < cols; a++)
            {
            r:
                int[] vs = null;
                try
                {
                    vs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                }
                catch (Exception e) { Console.WriteLine("Format error"); goto r; }
                for (int i = 0; i < rows; i++)
                {
                    array[a, i] = vs[i];
                }
            }

            Console.WriteLine("===========");

            for (int i = 0; i < cols; i++)
            {
                string rdy = "";
                for (int f = 0; f < rows; f++)
                {
                    rdy += array[i, f] + " ";
                }
                Console.WriteLine(rdy);
            }
            Console.WriteLine(smallest(array, cols, rows));
            Console.ReadLine();
        }

        public static string smallest(int[,] array, int rows, int cols)
        {
            string p = "";

            for (int i = 0; i < cols; i++)
            {
                int smallest = array[0, i];
                for (int f = 0; f < rows; f++)
                {
                    if (array[f, i] < smallest)
                    {
                        smallest = array[f, i];
                    }
                }
                p += smallest + " ";
            }
            return p;
        }
    }
}