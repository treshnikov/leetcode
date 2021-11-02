using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    public static class LetterCombinations
    {
        public static IList<string> Main(string digits)
        {
            var res = new List<string>();
            if (digits == null || digits.Length == 0)
            {
                return res;
            }

            var tmp = "";
            Backtrack(digits, 0, tmp, res);

            return res;
        }

        private static Dictionary<char, string> dict = new Dictionary<char, string>{
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"},
            };

        private static void Backtrack(string digits, int currentDigintIdx, string tmp, IList<string> res)
        {
            if (currentDigintIdx == digits.Length)
            {
                res.Add(tmp);
                return;
            }

            var currentDigit = digits[currentDigintIdx];
            var currentDigitLetters = dict[currentDigit];
            for (int letterIdx = 0; letterIdx < currentDigitLetters.Length; letterIdx++)
            {
                tmp += currentDigitLetters[letterIdx];
                Backtrack(digits, currentDigintIdx + 1, tmp, res);
                tmp = tmp.Remove(tmp.Length - 1);
            }
        }
    }           
}