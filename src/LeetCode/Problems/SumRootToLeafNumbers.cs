using System.Collections.Generic;

namespace LeetCode.Problems
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    /// <summary>
    /// https://leetcode.com/problems/sum-root-to-leaf-numbers/
    /// </summary>
    public class SumNumbersProblem
    {
        public int SumNumbers(TreeNode root)
        {
            var sum = 0;
            var stack = new List<int>();
            Backtrack(root, ref sum, stack);

            return sum;
        }

        internal static int ParseStack(List<int> stack)
        {
            var sum = 0;
            var i = 1;
            foreach (var val in stack)
            {
                sum += val * i;
                i *= 10;
            }

            return sum;
        }

        private void Backtrack(TreeNode root, ref int sum, List<int> stack)
        {
            if (root == null) return;

            if (root.left == null && root.right == null)
            {
                stack.Insert(0, root.val);

                // extract number
                var val = ParseStack(stack);

                // add
                sum += val;
            }
            else
            {
                stack.Insert(0, root.val);
            }

            Backtrack(root.left, ref sum, stack);
            Backtrack(root.right, ref sum, stack);

            stack.RemoveAt(0);
        }
    }
}