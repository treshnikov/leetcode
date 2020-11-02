using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class AddTwoNumbers
    {

        // Input: l1 = [2,4,3], l2 = [5,6,4]
        // Output: [7,0,8]
        // Explanation: 342 + 465 = 807.

        // Input: [9,9,9,9,9,9,9], [9,9,9,9]
        // Output: [8,9,9,9,0,0,0,1]
        public static ListNode Main(ListNode l1, ListNode l2)
        {
            var a = l1;
            var b = l2;

            ListNode head = null;
            ListNode previousNode = null;
            int delta = 0;
            while (true)
            {
                var sum = (a == null ? 0 : a.val) + (b == null ? 0 : b.val) + delta;

                var node = new ListNode
                {
                    val = sum > 9
                        ? sum - 10
                        : sum
                };

                delta = (int)(sum / 10);

                if (previousNode == null)
                {
                    head = node;
                }
                else
                {
                    previousNode.next = node;
                }

                previousNode = node;
                a = a == null ? null : a.next;
                b = b == null ? null : b.next;

                if (a == null && b == null)
                {
                    break;
                }
            }

            if (delta != 0)
            {
                var newNode = new ListNode(delta);
                previousNode.next = newNode;
            }

            return head;
        }
    }

}