using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Remove_Duplicates_from_Sorted_Array
    {
        //Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number   of unique elements in nums


        public static void Run()
        {
            int[] nums1 = new int[] { 1, 1, 2, 3 };

            Solution s = new Solution();

            int k = s.RemoveDuplicates(nums1);

            Console.WriteLine("Number of unique elements: " + k);

            for (int i = 0; i < k ; i++)
            {

                Console.WriteLine(nums1[i] + " ");
            }
        }

        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                if(nums.Length == 0) return 0;

                int uniquePointer = 0;

                for (int iteratePointer = 1; iteratePointer < nums.Length; iteratePointer++)
                {
                    //If the current element is not a duplicate (Unique), update the array
                    if (nums[iteratePointer] != nums[uniquePointer])
                    {
                        uniquePointer++;
                        nums[uniquePointer] = nums[iteratePointer];

                    }
                }

                return uniquePointer + 1;
            }
        }
    }
}
