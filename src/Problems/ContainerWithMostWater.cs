using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public static class ContainerWithMostWater
    {
        // https://leetcode.com/problems/container-with-most-water/
        public static int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var maxSqueare = 0;
            var square = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    square = (right - left) * height[left];
                    if (square > maxSqueare)
                        maxSqueare = square;
                    left = left + 1;
                }
                else
                {
                    square = (right - left) * height[right];
                    if (square > maxSqueare)
                    {
                        maxSqueare = square;
                    }
                    right = right - 1;
                }
            }

            return maxSqueare;
        }

    }
}
