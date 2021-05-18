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
                    "<name>", "Ana", "Felipe"
                };
            names.Add("Grant");
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[1]}");
            Console.WriteLine($"I've added {names[2]}, {names[3]} and {names[4]} to the list");
            Console.WriteLine($"The list has {names.Count} people in it");
            
            
            var index = names.IndexOf("Felipe");
                if (index == -1)
                {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                }
                else
                {
                    Console.WriteLine($"The name {names[index]} is at index {index}");
                }

            index = names.IndexOf("Not Found");
                if (index == -1)
                {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                }
                else
                {
                    Console.WriteLine($"The name {names[index]} is at index {index}");

                }
        }
    }
}
