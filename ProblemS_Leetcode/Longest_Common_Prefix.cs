using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Longest_Common_Prefix
    {
        //Write a function to find the longest common prefix string amongst an array of strings.
        //If there is no common prefix, return an empty string "".


        public static void Run()
        {
            string[] strs1 = ["flower", "flow", "flight"];
            string[] strs2 = ["dog", "racecar", "car"];
            string[] strs3 = ["Ahmed", "AhMohammed", "AhEldabaa"];

            Solution result =new Solution();
            Console.WriteLine($"Longest Common Prefix for strs1 : {result.LongestCommonPrefix(strs1)}");
            Console.WriteLine($"Longest Common Prefix for strs2 : {result.LongestCommonPrefix(strs2)}");
            Console.WriteLine($"Longest Common Prefix for strs3 : {result.LongestCommonPrefix(strs3)}");
        }

        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs == null || strs.Length == 0) {
                    return "";
                }

                string prefix = strs[0];

                for (int i = 1; i < strs.Length; i++)
                {
                    //Reduce the prefix length until it matches the start of the current string
                    while (strs[i].IndexOf(prefix) != 0)
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1);

                        if (prefix == "")
                        {
                            return "";
                        }
                    }
                }
                return prefix;
            }
        }

    }
}
