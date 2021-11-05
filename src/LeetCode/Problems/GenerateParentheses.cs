using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class GenerateParenthesesProblem
    {
        public IList<string> GenerateParentheses(int n)
        {
            var res = new List<string>();
            Backtrack(res, n, 0, 0, string.Empty);
            return res;
        }

        internal void Backtrack(List<string> res, int n, int openCount, int closeCount, string temp)
        {
            if (openCount == n && closeCount == n)
            {
                res.Add(temp);
            }

            if (openCount < n)
            {
                Backtrack(res, n, openCount + 1, closeCount, temp + "(");
            }

            if (closeCount < n && openCount > closeCount)
            {
                Backtrack(res, n, openCount, closeCount + 1, temp + ")");
            }
        }
    }
}