using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_series_10_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 2: First 10 numbers in Fibonacci sequence");
            int n = 10;
            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            foreach (var number in fibonacci)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
