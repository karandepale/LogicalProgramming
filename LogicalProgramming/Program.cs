using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programming Assignment...");

            // PRINTING FIBONACCI SERIES 
            FibonacciSeries obj1 = new FibonacciSeries();
            obj1.PrintFibonnacciSeries();


            // Checking perfact number
            PerfactNumber obj2 = new PerfactNumber();
            obj2.CheckPerfactNum();


            // Checking prime nuber
            PrimeNumber obj3 = new PrimeNumber();
            obj3.checkPrimeNum();


            // Reverse A Number
            ReverseANumber obj4 = new ReverseANumber();
            obj4.ReverseNum();

        }
    }
}
