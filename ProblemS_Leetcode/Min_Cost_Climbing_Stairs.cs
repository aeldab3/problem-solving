using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Min_Cost_Climbing_Stairs
    {
        /*
            764. Min Cost Climbing Stairs
            You are given an integer array cost where cost[i] is the cost of ith step on a staircase.Once you pay the cost, you can either climb one or two steps.
            You can either start from the step with index 0, or the step with index 1.
            Return the minimum cost to reach the top of the floor.
        */

        public static void Run()
        {
            int[] cost = { 10, 15, 20 };
            Solution s = new Solution();
            int result = s.MinCostClimbingStairs(cost);
            Console.WriteLine("Minimum cost to climb the stairs: " + result);
        }

        public class Solution
        {
            public int MinCostClimbingStairs(int[] cost)
            {
                int n = cost.Length;
                if (n == 0) return 0;
                if (n == 1) return cost[0];

                int first = cost[0];
                int second = cost[1];

                for (int i = 2; i < n; i++)
                {
                    int current = cost[i] + Math.Min(first, second);
                    first = second;
                    second = current;
                }
                return Math.Min(first, second);
            }
        }
    }
}
