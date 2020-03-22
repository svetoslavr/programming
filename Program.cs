using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] input = new string[text.Count()];
            int b = 0;
            foreach(var item in text)
            {
                input[b] = item.ToString();
                b++;
            }
            string duma = "";
            for(int i =3; i< text.Count(); i++)
            {
                duma += input[i];
            }
            string duma2 = "";
            for (int i = 0; i < text.Count()-3; i++)
            {
                duma2 += input[i];
            }
          
            string duma3 = "";

            for (int i = 3; i < text.Count()-3; i++)
            {
                duma3 += input[i];
            }

            Console.WriteLine(duma);
            Console.WriteLine(duma2);
            Console.WriteLine(duma3);
            Console.ReadLine();
        }
    }
}
