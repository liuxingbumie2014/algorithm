namespace Code.hot100.linkList;

// 反转链表
// 定义虚拟头节点
public class ReverseList
{
    public static ListNode Solution(ListNode head)
    {
        ListNode pre = null, node = head;
        while (node != null)
        {
            var tmp = node.next;
            node.next = pre;
            pre = node;
            node = tmp;
        }
        
        return pre;
    }
}