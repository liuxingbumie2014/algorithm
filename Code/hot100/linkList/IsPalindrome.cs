using System.Text;

namespace Code.hot100.linkList;

/// <summary>
/// 回文链表
/// 遍历构造字符串，双指针
/// </summary>
public class IsPalindrome
{
    public static bool Solution(ListNode head)
    {
        List<int> res = new();
        while (head != null)
        {
            res.Add(head.val);
            head = head.next;
        }

        int left = 0, right = res.Count - 1;

        while (left < right)
        {
            if (res[left] != res[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}