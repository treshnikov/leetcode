using System.Linq;
using System;
using System.Text;

namespace LeetCode.Problems
{
    //https://leetcode.com/problems/add-binary
    public static class AddBinaryProblem
    {
        public static string AddBinary(string a, string b)
        {
            var aIdx = a.Length - 1;
            var bIdx = b.Length - 1;
            var res = new StringBuilder(a.Length + b.Length);
            bool addOne = false;

            while (true)
            {
                char aChar = aIdx >= 0
                    ? a[aIdx]
                    : '0';

                char bChar = bIdx >= 0
                    ? b[bIdx]
                    : '0';

                int sum = int.Parse(new string(new char[]{aChar})) + int.Parse(new string(new char[]{bChar})) + (addOne ? 1 : 0);
                switch (sum)
                {
                    case 0:
                        res.Append('0');
                        addOne = false;
                        break;
                     case 1:
                        res.Append('1');
                        addOne = false;
                        break;
                     case 2:
                        res.Append('0');
                        addOne = true;
                        break;
                     case 3:
                        res.Append('1');
                        addOne = true;
                        break;

                    default:
                        throw new ArgumentException("sum");
                }

                aIdx--;
                bIdx--;

                if (aIdx < 0 && bIdx < 0)
                {
                    if (addOne)
                    {
                        res.Append('1');
                    }
                    return new string(res.ToString().Reverse().ToArray());
                }

            }

            throw new Exception();
        }
    }
}
