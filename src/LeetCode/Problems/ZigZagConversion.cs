using System;
using System.Text;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/zigzag-conversion/
    public static class ZigZagConversion
    {
        // Input: s = "PAYPALISHIRING", numRows = 3
        // Output: "PAHNAPLSIIGYIR"

        // Input: s = "PAYPALISHIRING", numRows = 4
        // Output: "PINALSIGYAHRPI"
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var res = new StringBuilder();
            int cycleLength = 2 * numRows - 2;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j + i < s.Length; j += cycleLength)
                {
                    res.Append(s[j + i]);
                    if (i != 0 &&
                        i != numRows - 1 &&
                        j + cycleLength - i < s.Length)
                    {
                        res.Append(s[j + cycleLength - i]);
                    }
                }
            }
            return res.ToString();
        }
    }
}
