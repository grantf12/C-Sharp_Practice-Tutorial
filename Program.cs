using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
                {
                    "<name>", "Anna", "Felipe"
                };
            names.Add("Grant");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}");
            }
        }
    }
}
