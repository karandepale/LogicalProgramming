using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CoupenNumber
    {
        public void CoupenNumberr()
        {
            int[] couponNumbers;

            Console.WriteLine("Enter the number of distinct coupon numbers:");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count < 1)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer:");
            }

            couponNumbers = GenerateDistinctCoupons(count);
            Console.WriteLine("Distinct Coupon Numbers:");
            foreach (int coupon in couponNumbers)
            {
                Console.Write(coupon + " ");
            }

            int totalRandomNumbers = GenerateRandomNumbersToGetDistinctCoupons(couponNumbers);
            Console.WriteLine("\nTotal random numbers needed to have all distinct numbers: " + totalRandomNumbers);
        }

        // Function to generate distinct coupon numbers
        public static int[] GenerateDistinctCoupons(int count)
        {
            Random random = new Random();
            HashSet<int> distinctCoupons = new HashSet<int>();

            while (distinctCoupons.Count < count)
            {
                int coupon = random.Next(1, count + 1);
                distinctCoupons.Add(coupon);
            }

            int[] couponArray = new int[distinctCoupons.Count];
            distinctCoupons.CopyTo(couponArray);

            return couponArray;
        }

        // Function to generate random numbers until all distinct coupon numbers are obtained
        public static int GenerateRandomNumbersToGetDistinctCoupons(int[] couponNumbers)
        {
            Random random = new Random();
            HashSet<int> obtainedCoupons = new HashSet<int>();
            int totalRandomNumbers = 0;

            while (obtainedCoupons.Count < couponNumbers.Length)
            {
                int randomNumber = random.Next(1, couponNumbers.Length + 1);
                totalRandomNumbers++;

                if (!obtainedCoupons.Contains(randomNumber))
                {
                    obtainedCoupons.Add(randomNumber);
                }
            }

            return totalRandomNumbers;
        }

    }
}
