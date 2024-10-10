using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Remove_Duplicates_from_Sorted_Array_II
    {
        //Given an integer array nums sorted in non-decreasing order, remove some duplicates in-place such that each unique element appears at most twice. The relative order of the elements should be kept the same.
        public static void Run()
        {
            int[] nums1 = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

            Solution s = new Solution();

            int k = s.RemoveDuplicates(nums1);

            Console.WriteLine(k);

            for ( int i = 0; i < k; i++ )
            {
                Console.Write($"{nums1[i] + ", "}");
            }
        }

        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                if (nums.Length <= 2) return nums.Length;

                //start from index 2 because we allow the first two elements by default
                int uniquePointer = 2;

                for (int iteratePointer = 2;  iteratePointer < nums.Length; iteratePointer++)
                {
                    if (nums[iteratePointer] != nums[uniquePointer - 2])
                    {
                        nums[uniquePointer] = nums[iteratePointer];
                        uniquePointer++;
                    }
                }

                return uniquePointer;
            }
        }
    }
}
