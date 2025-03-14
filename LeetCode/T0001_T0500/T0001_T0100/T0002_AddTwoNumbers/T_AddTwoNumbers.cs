namespace LeetCode.T0001_T0500.T0001_T0100.T0002_AddTwoNumbers;

public class T_AddTwoNumbers
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

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var startNode = new ListNode();
        var currentNode = startNode;
        var addNextValue = 0;

        while (l1 is not null || l2 is not null)
        {
            var l1Value = l1 is null ? 0 : l1.val;
            var l2Value = l2 is null ? 0 : l2.val;

            var currentValue = l1Value + l2Value + addNextValue;
            addNextValue = currentValue >= 10 ? 1 : 0;
            currentValue %= 10;

            currentNode.next = new ListNode(currentValue);
            currentNode = currentNode.next;

            if (l1 is not null)
                l1 = l1.next;
            if (l2 is not null)
                l2 = l2.next;
        }

        if (addNextValue == 1)
            currentNode.next = new ListNode(addNextValue);

        return startNode.next;
    }
}
