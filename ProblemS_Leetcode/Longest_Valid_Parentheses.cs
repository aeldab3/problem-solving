using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Longest_Valid_Parentheses
    {
        /*
          32- Longest Valid Parentheses
          Given a string containing just the characters '(' and ')', return the length of the longest valid (well-formed) parentheses substring.
        */
        public static void Run()
        {
            Solution stack = new Solution();
            int input1 = stack.LongestValidParentheses("(()");
            int input2 = stack.LongestValidParentheses(")()())");
            int input3 = stack.LongestValidParentheses("");
            int input4 = stack.LongestValidParentheses("()()()()()(((())))))(((())()()()()");
            Console.WriteLine(input1);
            Console.WriteLine(input2);
            Console.WriteLine(input3);
            Console.WriteLine(input4);
        }

        public class Solution
        {
            public int LongestValidParentheses(string s)
            {
                Stack<int> stack = new Stack<int>();
                stack.Push(-1);
                int maxLength = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                        stack.Push(i);
                    else
                    {
                        stack.Pop();

                        if (stack.Count == 0)
                            stack.Push(i);
                        else
                            maxLength = Math.Max(maxLength, i - stack.Peek());
                    }
                }
                return maxLength;
            }
        }
    }
}
