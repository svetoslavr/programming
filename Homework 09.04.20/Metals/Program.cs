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
            Dictionary<string, int> resources = new Dictionary<string, int>();
            resources.Add("Gold", 0);
            resources.Add("Silver", 0);
            resources.Add("Copper", 0);
            while (true)
            {
                Console.Write(" Type of metal: ");
                string met = Console.ReadLine().ToLower();
                if ( met == "stop" || met   == "copper" || met == "silver" || met == "gold")
                {
                    if (met != "stop") 
                    {
                        int b = 0;
                        Console.Write($"Enter b {met}: ");
                        try
                        {
                            b = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e) { Console.WriteLine(" Type a number:"); }
                        switch (met)
                        {                            
                            case "copper":
                                {
                                    resources["Copper"] += b;
                                    Console.WriteLine($"{b} copper added.");
                                    break;
                                }
                            case "silver":
                                {
                                    resources["Silver"] += b;
                                    Console.WriteLine($"{b} silver added.");
                                    break;
                                }
                            case "gold":
                                {
                                    resources["Gold"] += b;
                                    Console.WriteLine($"{b} gold added.");
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Gold --> {resources["Gold"]}");     
                        Console.WriteLine($"Silver --> {resources["Silver"]}"); 
                        Console.WriteLine($"Copper --> {resources["Copper"]}"); 
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
