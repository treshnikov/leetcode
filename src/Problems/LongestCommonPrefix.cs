using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    public static class LongestCommonPrefix
    {
        public static string Main(string[] strs)
        {
            // handle corner cases
            if (strs == null || strs.Length == 0 || strs[0] == string.Empty)
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            var res = new StringBuilder();
            var charIdx = 0;
            while (true)
            {
                if (charIdx >= strs[0].Length)
                {
                    return res.ToString();
                }

                var etalonChar = strs[0][charIdx];
                for (int i = 1; i < strs.Length; i++)
                {
                    var str = strs[i];
                    if (charIdx >= str.Length)
                    {
                        return res.ToString();
                    }

                    if (str[charIdx] != etalonChar)
                    {
                        return res.ToString();
                    }
                }

                res.Append(strs[0][charIdx]);

                charIdx++;
            }
        }

    }
}
