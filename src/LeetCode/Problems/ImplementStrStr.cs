using System;

namespace LeetCode.Problems
{
    public class ImplementStrStr 
    {
        // https://leetcode.com/problems/implement-strstr/
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
            {
                return -1;
            }

            var needleCharIdx = 0;
            var hayStackCharIdx = 0;
            while (hayStackCharIdx < haystack.Length)
            {
                if (haystack[hayStackCharIdx] == needle[needleCharIdx])
                {
                    needleCharIdx++;
                }
                else
                {
                    hayStackCharIdx -= needleCharIdx ;
                    needleCharIdx = 0;
                    hayStackCharIdx++;
                    continue;
                }

                if (needleCharIdx == needle.Length)
                {
                    return hayStackCharIdx - needle.Length + 1;
                }

                hayStackCharIdx++;
            }

            return -1;
        }
    }
}
