using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumber
    {
        public void checkPrimeNum()
        {
            int number;

            Console.WriteLine("Enter a positive integer:");
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer:");
            }

            if (IsPrimeNumber(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
        public static bool IsPrimeNumber(int number)
        {
            // 0 and 1 are not prime numbers
            if (number == 0 || number == 1)
                return false;

            // Check for divisibility from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; // Not a prime number
                }
            }

            return true; // Prime number
        }
    }
}
