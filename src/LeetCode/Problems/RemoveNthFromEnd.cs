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
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/submissions/
    /// </summary>
    public class RemoveNthFromEndProblem
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null && n == 1)
            {
                return null;
            }

            var list = new List<ListNode>();
            var currentNode = head;
            while (currentNode != null)
            {
                list.Add(currentNode);
                currentNode = currentNode.next;

                if (list.Count > n + 1)
                {
                    list.RemoveAt(0);
                }
            }

            if (list.Count != n + 1)
            {
                return head.next;
                 
            }

            var nodeToDelete = list[1];
            list[0].next = nodeToDelete.next;

            return head;
        }
    }
}