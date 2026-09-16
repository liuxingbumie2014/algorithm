namespace Code.hot100.linkList;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
    }
}

public class GetIntersectionNode
{
    public static ListNode Solution(ListNode headA, ListNode headB)
    {
        ListNode a = headA, b = headB;
        while (a != b)
        {
            if (a == null)
                a = headB;
            else
                a = a.next;
            
            if (b == null)
                b = headA;
            else
                b = b.next;
        }

        return a;
    }
}