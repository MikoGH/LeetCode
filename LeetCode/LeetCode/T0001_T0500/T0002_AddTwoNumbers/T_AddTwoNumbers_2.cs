namespace LeetCode.T0001_T0500.T0002_AddTwoNumbers;

public class T_AddTwoNumbers_2
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

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int addValue = 0)
    {
        if (l1 is null && l2 is null && addValue == 0)
            return null;

        var sum = (l1 is null ? 0 : l1.val) + (l2 is null ? 0 : l2.val) + addValue;

        return new ListNode(sum % 10, AddTwoNumbers(l1?.next, l2?.next, sum / 10));
    }
}
