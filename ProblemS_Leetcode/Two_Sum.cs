using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Two_Sum
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        public static void Run()
        {
        Two_Sum twoSum = new Two_Sum();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = twoSum.TwoSum(nums, target);
        Console.WriteLine($"Two Sum Indices: {result[0]}, {result[1]}");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < (nums.Count() - 1); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return new int[0];
        }
    }
}
