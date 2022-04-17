using System;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/increasing-order-search-tree/
    public class IncreasingOrderSearchTree
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode newRoot = new TreeNode();
            TreeNode current = newRoot;
            HandleNode(root, ref current);

            return newRoot.right;
        }

        private static void HandleNode(TreeNode node, ref TreeNode current)
        {
            if (node == null)
                return;

            HandleNode(node.left, ref current);
            current.right = node;
            current = current.right;
            current.left = null;
            HandleNode(node.right, ref current);
        }
    }
}