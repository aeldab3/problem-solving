using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemS_Leetcode
{
    internal class Integer_to_Roman
    {
        public static void Run()
        {

            int x1 = 18;   //XVIII
            int x2 = 1;    //I
            int x3 = 1999; //MCMXCIX

            Solution s = new Solution();

            Console.WriteLine($"The Roman numeral for number {x1} is {s.IntToRoman(x1)}");
            Console.WriteLine($"The Roman numeral for number {x2} is {s.IntToRoman(x2)}");
            Console.WriteLine($"The Roman numeral for number {x3} is {s.IntToRoman(x3)}");
        }

        public class Solution
        {
            public string IntToRoman(int num)
            {
                Dictionary<int, string> romanMap = new Dictionary<int, string>() {
                   {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"}, {100, "C"}, {90, "XC"},
                   {50, "L"}, {40, "XL"}, {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
                };

                //Initialize a StringBuilder to store the resulting Roman numeral
                StringBuilder result = new StringBuilder();

                //Iterate through the dictionary keys(starting from the highest value)
                foreach (var value in romanMap.Keys)
                {
                    while (num >= value)
                    {
                        result.Append(romanMap[value]);
                        num -= value;
                    }
                }
                return result.ToString();
            }
        }
    }
}
