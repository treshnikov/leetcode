using System.Collections.Generic;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/binary-tree-inorder-traversal/
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            HandleNode(root, res);

            return res;
        }

        public void HandleNode(TreeNode node, IList<int> res)
        {
            if (node == null)
            {
                return;
            }

            HandleNode(node.left, res);
            res.Add(node.val);
            HandleNode(node.right, res);
        }
    }
}