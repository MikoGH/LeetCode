namespace LeetCode.T1001_T1500.T1201_T1300.T1290_ConvertBinaryNumberInALinkedListToInteger;

public class T_ConvertBinaryNumberInALinkedListToInteger
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    public int GetDecimalValue(ListNode head)
    {
        var result = head.val;
        while (head.next is not null)
        {
            head = head.next;
            result = result * 2 + head.val;
        }

        return result;
    }
}
