using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Roman_To_Integer
    {
        //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        public static void Run()
        {
            string s1 = "XVIII";    // 18
            string s2 = "I";       // 1
            string s3 = "MCMXCIX";  // 1999
            Solution s = new Solution();

            Console.WriteLine($"Roman numeral {s1} equals {s.RomanToInt(s1)}");
            Console.WriteLine($"Roman numeral {s2} equals {s.RomanToInt(s2)}");
            Console.WriteLine($"Roman numeral {s3} equals {s.RomanToInt(s3)}");

        }

        public class Solution
        {
            public int RomanToInt(string s)
            {
                Dictionary<char, int> romanMap = new Dictionary<char, int>()
                {
                    {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
                };

                int total = 0;
                int prevValue = 0;

                for (int i = s.Length - 1; i >= 0; i--) {
                    int currentValue = romanMap[s[i]];

                    if (currentValue < prevValue)
                    {
                        total -= currentValue;
                    }
                    else
                    {
                        total += currentValue;
                    }

                    prevValue = currentValue;
                }
                return total;
            }
        }
    }
}
