// 11. 盛最多水的容器
// 给定一个长度为 n 的整数数组 height 。有 n 条垂线，第 i 条线的两个端点是 (i, 0) 和 (i, height[i]) 。
// 找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。
// 返回容器可以储存的最大水量。
//     
// 输入：[1,8,6,2,5,4,8,3,7]
// 输出：49 

// 思路：水桶在越来越窄的情况下只有换短板才有可能通过增加高度从而增加盛水量。
// maxArea = min(height[right], height[left]) * (right - left);
// 左右指针位于左右边界，此时(right - left)最大； 求最大值考虑提高短板，移动较小值的指针
    
namespace Code.hot100.doublePointer;

public class MaxArea
{
    public static int Solution(int[] height)
    {
        int result = int.MinValue;

        //碰撞指针
        int left = 0, right = height.Length - 1;
        while (left < right)
        {
            var minHeight = Math.Min(height[left], height[right]);
            var maxArea = minHeight * (right - left);
            result = Math.Max(result, maxArea);
            
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        // //暴力循环 n的平方
        // for (int i = 0; i < height.Length - 1; i++)
        // {
        //     for (int j = i + 1; j < height.Length; j++)
        //     {
        //         var minHeight = Math.Min(height[i], height[j]);
        //         var maxArea = minHeight * (j - i);
        //         result = Math.Max(result, maxArea);
        //     }
        // }
        return result;
    }
}