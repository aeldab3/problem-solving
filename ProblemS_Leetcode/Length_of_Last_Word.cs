using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Length_of_Last_Word
    {
        //Given a string s consisting of words and spaces, return the length of the last word in the string.
        //A word is a maximal substring consisting of non-space characters only.
        public static void Run()
        {
            string s1 = "Hello World";
            string s2 = "   fly me   to   the moon  ";

            Solution sol = new Solution();
            Console.WriteLine($"The last word is \"World\" with length {sol.LengthOfLastWord(s1)}");
            Console.WriteLine($"The last word is \"moon\" with length {sol.LengthOfLastWord(s2)}");

        }
        public class Solution
        {
            public int LengthOfLastWord(string s)
            {
                s = s.Trim();
                int lastWord = s.LastIndexOf(" ");
                return s.Length - lastWord -1;
            }
        }
    }
}
