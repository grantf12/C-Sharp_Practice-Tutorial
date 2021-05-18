using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            // var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            // var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            while (fibonacciNumbers.Count < 20)
            {
                fibonacciNumbers.Add(fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2]);
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}
