using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Climbing_Stairs
    {
        public static void Run()
        {
            int n = 5;
            Solution s = new Solution();
            int result = s.ClimbStairs(n);
            Console.WriteLine("Number of ways to climb " + n + " stairs: " + result);
        }

        public class Solution
        {
            public int ClimbStairs(int n)
            {
                if (n <= 2) return n;

                int first = 1;
                int second = 2;

                for (int i = 3; i <= n; i++)
                {
                    int third = first + second;
                    first = second;
                    second = third;
                }

                return second;
            }
        }
    }
}
