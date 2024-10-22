using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Add_Binary
    {
        //Given two binary strings a and b, return their sum as a binary string.
        public static void Run()
        {
            string a = "1010";
            string b = "1011";
            Solution s = new Solution();
            string result = s.AddBinary(a, b);
            Console.WriteLine("Result: " + result);
        }
        public class Solution
        {
            public string AddBinary(string a, string b)
            {
                StringBuilder result = new StringBuilder();
                int i = a.Length - 1;
                int j = b.Length - 1;
                int carry = 0;

                while (i >= 0 || j >= 0 || carry > 0) {
                    // Get the current digit from both strings, if available
                    int digitA = i >= 0 ? a[i] - '0' : 0;
                    int digitB = j >= 0 ? b[j] - '0' : 0;
                    int sum = carry + digitA + digitB;
                    result.Append(sum % 2);
                    carry = sum / 2;

                    i--;
                    j--;
                }
                // The result is built in reverse, so reverse it before returning
                char[] resultArray = result.ToString().ToCharArray();
                Array.Reverse(resultArray);
                return new string(resultArray);
            }
        }
    }
}
