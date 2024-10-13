using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Remove_Element
    {
        //Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

        public static void Run()
        {
            int[] nums = [3, 2, 2, 3];

            int val = 3;

            Solution s = new Solution();

            int k = s.RemoveElement(nums, val);

            for (int i = 0; i < k; i++) {

                Console.Write(nums[i] + " ");

            }
        }
        public class Solution
        {
            public int RemoveElement(int[] nums, int val)
            {
                if (nums == null || nums.Length == 0) return 0;

                int elementAfterRemoved = 0;

                for ( int iterator = 0; iterator < nums.Length; iterator ++)
                {
                    if (!nums[iterator].Equals(val))
                    {
                        nums[elementAfterRemoved] = nums[iterator];
                        elementAfterRemoved++;
                    }
                }

                return elementAfterRemoved;
            }   
        }
    }
}
