using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseANumber
    {
        public void ReverseNum()
        {
            int number;

            Console.WriteLine("Enter a positive integer:");
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer:");
            }

            int reversedNumber = Reverse(number);

            Console.WriteLine($"Reversed Number: {reversedNumber}");
        }
        public static int Reverse(int number)
        {
            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }

            return reverse;
        }
    }
}
