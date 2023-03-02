/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class ArmstrongNumber
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Which number would you like to check if it is an Armstrong number?");
            int number = Int32.Parse(Console.ReadLine());
            if (IsArmstrongNumber(number))
            {
                Console.WriteLine($"{number} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number");
            }
        }

        public static bool IsArmstrongNumber(int n)
        {
            int result = 0;
            string number = $"{n}";
            char[] nums = number.ToCharArray();
            foreach (char digit in nums)
            {
                result += (int) Math.Pow(Convert.ToInt32(digit) - 48, nums.Length);
            }
            if (result - n == 0)
            {
                return true;
            }
            return false;
        }
    }
}

*/