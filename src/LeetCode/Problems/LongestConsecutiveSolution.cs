using System;
using System.Collections.Generic;
//https://leetcode.com/problems/longest-consecutive-sequence/
public static class LongestConsecutiveSolution
{
    public static int LongestConsecutive(int[] nums)
    {
        var max = 0;
        var hashSet = new HashSet<int>(nums);

        foreach (var i in hashSet)
        {
            // a suggestion that this element is a start of sequence
            if (!hashSet.Contains(i - 1))
            {
                var current = i;
                var currentMax = 1;
                while (hashSet.Contains(current + 1))
                {
                    currentMax++;
                    current++;
                }

                max = Math.Max(currentMax, max);
            }
        }

        return max;
    }
}