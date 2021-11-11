using System.Collections.Generic;

namespace LeetCode.Problems
{

    public class SumOfLeftLeavesProblem
    {
        public static int Sum(TreeNode root)
        {
            var sum = 0;
            bool? cameFromLeftEdge = null;
            Backtrack(root, ref sum, cameFromLeftEdge);

            return sum;
        }

        internal static void Backtrack(TreeNode root, ref int sum, bool? cameFromLeftEdge)
        {
            if (root == null) return;

            if (root.left == null && root.right == null)
            {
                if (cameFromLeftEdge.HasValue && cameFromLeftEdge.Value)
                {
                    sum += root.val;
                }
            }

            Backtrack(root.left, ref sum, true);
            Backtrack(root.right, ref sum, false);
        }
    }
}