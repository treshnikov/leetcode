using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var openBrackets = new Stack<char>();
            foreach (var b in s)
            {
                switch (b)
                {
                    case '(':
                    case '[':
                    case '{':
                        openBrackets.Push(b);
                        break;

                    case ')':
                    case ']':
                    case '}':
                        char c;
                        if (!openBrackets.TryPop(out c))
                        {
                            return false;
                        }

                        if (b == ')' && c != '(') return false;
                        if (b == ']' && c != '[') return false;
                        if (b == '}' && c != '{') return false;
                        break;

                    default:
                        return false;
                }
            }

            return openBrackets.Count == 0;
        }
    }
}