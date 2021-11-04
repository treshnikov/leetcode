using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/string-to-integer-atoi
    public static class MyAtoi
    {
        public static int Do(string s)
        {
            var digits = new Dictionary<char, int> { { '1' , 1}, { '2', 2 }, { '3', 3 }, { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 }, { '8', 8 }, { '9', 9 }, { '0', 0 } };
            var isDigit = new Func<char, bool>(arg => { return digits.ContainsKey(arg); });

            bool negative = false;
            var res = 0;

            var i = 0;
            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            if (i < s.Length)
            {
                if (s[i] == '-')
                {
                    negative = true;
                    i++;
                }
                else if (s[i] == '+')
                {
                    i++;
                }
                else if (!isDigit(s[i]))
                {
                    return 0;
                }
            }

            for (int j = i; j <= s.Length - 1; j++)
            {
                var c = s[j];

                if (!isDigit(c))
                {
                    break;
                }

                if (res > 0 && negative)
                {
                    res = -res;
                    negative = false;
                }

                if (res > 0 && res > Int32.MaxValue / 10)
                {
                    return Int32.MaxValue;
                }
                else if (res < 0 && res < Int32.MinValue / 10)
                {
                    return Int32.MinValue;
                }

                res *= 10;
                var d = digits[c];

                if (res >= 0)
                {
                    if (res > Int32.MaxValue - d)
                        return Int32.MaxValue;
                    res += d;
                }
                else
                {
                    if (res < Int32.MinValue + d)
                        return Int32.MinValue;
                    res -= d;
                }
            }

            return negative ? -res : res;
        }

    }
}
