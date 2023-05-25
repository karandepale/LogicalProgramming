using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class FibonacciSeries
    {
        public void PrintFibonnacciSeries()
        {
            int count;

            Console.WriteLine("Enter the number of terms to generate in the Fibonacci series:");
            while (!int.TryParse(Console.ReadLine(), out count) || count < 1)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer:");
            }

            Console.WriteLine("Fibonacci Series:");

            // Display Fibonacci series
            for (int i = 0; i < count; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

