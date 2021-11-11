namespace LeetCode.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/swap-nodes-in-pairs/
    /// </summary>
    public class SwapNodesinPairs
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var current = head;
            var newHead = head.next;
            ListNode prev = null;

            while (current != null && current.next != null)
            {
                var next = current.next;

                current.next = current.next?.next;
                if (next != null) next.next = current;
                if (prev != null) prev.next = next;

                prev = current;
                current = current.next;
            }

            return newHead;

        }
    }
}