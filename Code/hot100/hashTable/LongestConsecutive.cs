// 128. 最长连续序列
// 给定一个未排序的整数数组 nums ，找出数字连续的最长序列（不要求序列元素在原数组中连续）的长度。
// 请你设计并实现时间复杂度为 O(n) 的算法解决此问题。
//
// 示例 1：
//
// 输入：nums = [100,4,200,1,3,2]
// 输出：4
// 解释：最长数字连续序列是 [1, 2, 3, 4]。它的长度为 4。
// 示例 2：
//
// 输入：nums = [0,3,7,2,5,8,4,6,0,1]
// 输出：9
// 示例 3：
//
// 输入：nums = [1,0,1,2]
// 输出：3

namespace Code.hot100.hashTable;
public class LongestConsecutive
{
    public static int Solution(int[] nums)
    {
        //先去重，然后判断是否为序列头；不是则跳过，是则进入下层循环
        if (nums.Length == 0) return 0;

        HashSet<int> filter = new HashSet<int>(nums);
        int maxLength = 0;
        foreach (var value in filter)
        {
            if (filter.Contains(value - 1)) continue;

            int length = 1;
            for (int i = 1; i < filter.Count; i++)
            {
                if (filter.Contains(value + i))
                    length++;
                else
                    break;
            }

            maxLength = Math.Max(maxLength, length);
        }

        return maxLength;

        // //暴力 先排序，再检测
        // Array.Sort(nums);
        // List<int> maxArray = new() { nums[0] };
        // int maxLength = 1;
        // for (int i = 1; i < nums.Length; i++)
        // {
        //     if (maxArray.Contains(nums[i]))
        //         continue;
        //     
        //     if (nums[i] - maxArray[^1] != 1)
        //     {
        //         maxLength = maxArray.Count > maxLength ? maxArray.Count : maxLength;
        //         maxArray.Clear();
        //     }
        //     maxArray.Add(nums[i]);
        // }
        //
        // return maxArray.Count > maxLength ? maxArray.Count : maxLength;
    }
}