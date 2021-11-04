using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public static class ReverseInteger
    {
        //https://leetcode.com/problems/reverse-integer
        public static int Do(int x)
        {
            long y = 0;
            while (x != 0)
            {
                y = y * 10 + x % 10;
                x /= 10;
            }
            return (y < int.MinValue || y > int.MaxValue) ? 0 : (int)y;
        }
    }
}
