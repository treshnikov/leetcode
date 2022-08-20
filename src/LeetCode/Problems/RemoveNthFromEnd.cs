using System.Collections.Generic;

namespace LeetCode.Problems
{
    // public class ListNode
    // {
    //     public int val;
    //     public ListNode next;
    //     public ListNode(int val = 0, ListNode next = null)
    //     {
    //         this.val = val;
    //         this.next = next;
    //     }
    // }

    /// <summary>
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list
    /// </summary>
    public class RemoveNthFromEndProblem
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null && n == 1)
            {
                return null;
            }

            var stack = new Stack<ListNode>();
            var current = head;
            while(current != null)
            {
                stack.Push(current);
                current = current.next;
            }

            var idx = 0;
            ListNode nodeToDelete;
            while(stack.Count > 0)
            {
                var node = stack.Pop();
                idx++;

                if (idx == n)
                {
                    nodeToDelete = node;

                    if (stack.Count == 0)
                    {
                        return head.next;
                    }
                    else
                    {
                        var prev = stack.Pop();
                        prev.next = nodeToDelete.next;
                        nodeToDelete.next = null;
                        nodeToDelete = null;

                        return head;
                    }
                }
            }
            return head;
        }
    }
}