using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/palindrome-number/
    public static class IntPalindrome
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            if (x == 0)
            {
                return true;
            }

            var reversInteger = new Func<int, int>(x =>
            {
                long y = 0;
                while (x != 0)
                {
                    y = y * 10 + x % 10;
                    x /= 10;
                }
                return (y < int.MinValue || y > int.MaxValue) ? 0 : (int)y;
            });

            return x == reversInteger(x);

        }

    }
}
