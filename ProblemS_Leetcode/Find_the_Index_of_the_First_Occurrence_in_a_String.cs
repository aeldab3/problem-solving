using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        //Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

        public static void Run()
        {
            string haystack = "AhmedMohammedEldabaa";
            string needle = "med";

            Solution s = new Solution();

            int result = s.StrStr(haystack, needle);

            Console.WriteLine(result);
        }
        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
                if (needle.Length == 0) return 0;

                return haystack.IndexOf(needle);
            }
        }
    }
}
