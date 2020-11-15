using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    public static class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {
            if (num < 1 || num > 3999 || num % 1 != 0)
            {
                return "";
            }
            var thousands = new List<string> { "", "M", "MM", "MMM" };
            var hundreds = new List<string> { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            var tens = new List<string> { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            var ones = new List<string> { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            var values = (num + 10000).ToString().Select(i => i.ToString()).ToArray();
            var roman = thousands[int.Parse(values[1])] + hundreds[int.Parse(values[2])] + tens[int.Parse(values[3])] + ones[int.Parse(values[4])];
            return roman;
        }

    }
}
