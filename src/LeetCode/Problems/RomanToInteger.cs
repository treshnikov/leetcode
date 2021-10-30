using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/roman-to-integer/
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var roman = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000 }};

            var res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var curr = s[i];
                var next = i < s.Length - 1
                    ? s[i + 1]
                    : '-';
                var currentChar = roman[curr];
                var nextChar = next != '-'
                    ? roman[next]
                    : 0;

                if (currentChar < nextChar)
                {
                    res += -currentChar + nextChar;
                    i++;
                }
                else
                {
                    res += currentChar;
                }
            }

            return res;
        }

    }
}
