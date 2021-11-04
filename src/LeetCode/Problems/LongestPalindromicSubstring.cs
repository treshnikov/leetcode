using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/longest-palindromic-substring/
    public static class LongestPalindromicSubstring
    {
        public static string Do(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var res = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                // odd palindrom
                var start = i;
                var end = i;
                while (start >= 0 && end < s.Length && s[start] == s[end])
                {
                    if (end - start + 1 > res.Length)
                    {
                        res = s.Substring(start, end - start + 1);
                    }
                    start--;
                    end++;
                }

                // even palindrom
                start = i;
                end = i + 1;
                while (start >= 0 && end < s.Length && s[start] == s[end])
                {
                    if (end - start + 1 > res.Length)
                    {
                        res = s.Substring(start, end - start + 1);
                    }
                    start--;
                    end++;
                }
            }

            return res;
        }
    }
}
