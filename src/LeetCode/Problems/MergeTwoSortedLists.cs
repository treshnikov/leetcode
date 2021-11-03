namespace LeetCode.Problems
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode head;
            ListNode current;
            ListNode i;
            ListNode j;
            if (l1.val < l2.val)
            {
                head = l1;
                i = l1.next;
                j = l2;
            }
            else
            {
                head = l2;
                i = l1;
                j = l2.next;
            }
            current = head;

            while (true)
            {
                if (i == null)
                {
                    current.next = j;
                    break;
                }

                if (j == null)
                {
                    current.next = i;
                    break;
                }

                if (i.val < j.val)
                {
                    current.next = i;
                    current = current.next;
                    i = i.next;
                }
                else if (i.val > j.val)
                {
                    current.next = j;
                    current = current.next;
                    j = j.next;
                }
                else
                {
                    current.next = i;
                    current = current.next;
                    i = i.next;

                    current.next = j;
                    current = current.next;
                    j = j.next;
                }
            }

            return head;
        }
    }
}