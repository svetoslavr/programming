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
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            while (true)
            {
                var a = Console.ReadLine().Split(' ');
                string contact = a[0].ToLower();
                switch (contact)
                {
                    case "A":
                        {
                            contacts.Add(a[1], a[2]);
                            break;
                        }
                    case "S":
                        {
                            if (contacts.ContainsKey(a[1]))
                            {
                                Console.WriteLine($"{a[1]} --> {contacts[a[1]]}");
                            }
                            else
                            {
                                Console.WriteLine($"This contact does not exist.");
                            }
                            break;
                        }
                    case "END":
                        {
                            return;
                        }
                }
               
            }
            Console.ReadLine();
        }
    }
}