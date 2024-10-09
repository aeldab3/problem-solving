using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemS_Leetcode
{
    internal class Valid_Parentheses
    {
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        public static void Run()
        {
            Solution stack = new Solution();
            Console.WriteLine(stack.IsValid("()"));
            Console.WriteLine(stack.IsValid("()[]{}"));
            Console.WriteLine(stack.IsValid("(]"));
        }

        public class Solution
        {
            public bool IsValid(string s)
            {
                Stack<char> parentheses = new Stack<char>();

                foreach(char c in s)
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        parentheses.Push(c);
                    }
                    else if (c == ')' || c == '}' || c == ']')
                    {
                        if (parentheses.Count == 0)
                        {
                            return false;
                        }

                        var top = parentheses.Pop();
                        if ((c == ')' && top != '(') ||
                            (c == ']' && top != '[') ||
                            (c == '}' && top != '{'))
                        {
                            return false;
                        }
                    }
                }
                return parentheses.Count ==0;
            }
        }
    }
}
