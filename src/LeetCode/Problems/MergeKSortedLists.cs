using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/merge-k-sorted-lists/
    /// </summary>
    public class MergeKSortedLists
    {
        public static ListNode Do(ListNode[] lists)
        {
            ListNode head = null;
            ListNode current = null;
            var pointers = new List<ListNode>(lists);
            var minNodeIdx = GetNodeIdxWithMinValue(pointers);
            while (minNodeIdx != -1)
            {
                // head initialization
                if (head == null)
                {
                    head = pointers[minNodeIdx];
                    current = head;
                }
                else
                {
                    current.next = pointers[minNodeIdx];
                    current = current.next;
                }

                pointers[minNodeIdx] = pointers[minNodeIdx]?.next;
                minNodeIdx = GetNodeIdxWithMinValue(pointers);
            }

            return head;
        }

        private static int GetNodeIdxWithMinValue(List<ListNode> nodes)
        {
            int res = -1;

            for (int i = 0; i < nodes.Count; i++)
            {
                var n = nodes[i];
                if (n == null)
                {
                    continue;
                }

                if (res == -1)
                {
                    res = i;
                }

                if (nodes[res].val > n.val)
                {
                    res = i;
                }
            }

            return res;
        }
    }
}