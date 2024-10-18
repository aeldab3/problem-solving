using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemS_Leetcode
{
    internal class Plus_One
    {
        //You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
        //Increment the large integer by one and return the resulting array of digits.
        public static void Run()
        {
            int[] newD1 = [1, 2, 3];
            int[] newD2 = [8, 4, 9];

            Solution s = new Solution();
            Console.WriteLine($"The Result is [{ string.Join(",", s.PlusOne(newD1))}]");
            Console.WriteLine($"The Result is [{string.Join(",", s.PlusOne(newD2))}]");

        }
        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    // Add one to the current digit
                    digits[i]++;

                    if (digits[i] < 10)
                    {
                        return digits;
                    }

                    digits[i] = 0;
                }

                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                return newDigits;

            }
        }
    }
}
