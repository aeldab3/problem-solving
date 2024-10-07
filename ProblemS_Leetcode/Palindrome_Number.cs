using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Palindrome_Number
    {
        //Given an integer x, return true if x is a palindrome, and false otherwise.

        public static void Run()
        {
            int x1 = 138;
            int x2 = 18;
            int x3 = 181;

            Solution s = new Solution();
            Console.WriteLine($"Is {x1} a palindrome? {s.IsPalindrome(x1)}");
            Console.WriteLine($"Is {x2} a palindrome? {s.IsPalindrome(x2)}");
            Console.WriteLine($"Is {x3} a palindrome? {s.IsPalindrome(x3)}");

        }
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                if (x < 0) return false;

                string strX = x.ToString();

                for (int i = 0; i < strX.Length / 2; i++)
                {
                    if (strX[i] != strX[strX.Length - 1 - i]) return false;
                }

                return true;
            }
        }
    }
}
