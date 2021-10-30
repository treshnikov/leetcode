using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/longest-substring-without-repeating-characters
    // Input: s = "pwwkew"
    // Output: 3
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var map = new HashSet<char>();
            var start = 0;
            var end = 0;
            var max = 0;
            while(end < s.Length)
            {
                var c = s[end];
                if (!map.Contains(c))
                {
                    map.Add(c);
                    end++;
                    max = Math.Max(max, map.Count);
                }
                else 
                {
                    map.Remove(s[start]);
                    start++;
                }
            }

            return max;
        }

    }
}
