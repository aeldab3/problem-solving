using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Search_Insert_Position
    {
        //Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        public static void Run()
        {
            int[] nums1 = [1, 3, 5, 6]; 
            int target = 5;

            Solution s = new Solution();
            int targeIndex = s.SearchInsert(nums1, target);
            Console.WriteLine(targeIndex);
        }
        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {
                int left = 0;
                int right = nums.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (nums[mid] == target)
                    {
                        return mid;
                    }

                    else if (nums[mid] > target)
                    {
                        right = mid - 1;
                    }

                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                }
                return left;
            }
        }
    }
}
