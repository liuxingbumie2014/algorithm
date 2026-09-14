namespace Code.hot100.doublePointer;

public class ThreeSum
{
    public static IList<IList<int>> Solution(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1, k = nums.Length - 1;
            
        }

        return res;
    }

    //暴力
    // public static IList<IList<int>> Solution(int[] nums)
    // {
    //     IList<IList<int>> res = new List<IList<int>>();
    //     HashSet<string> filter = new();
    //
    //     for (int i = 0; i < nums.Length - 2; i++)
    //     {
    //         for (int j = i + 1; j < nums.Length - 1; j++)
    //         {
    //             for (int k = j + 1; k < nums.Length; k++)
    //             {
    //                 if (nums[i] + nums[j] + nums[k] == 0)
    //                 {
    //                     var target = new List<int>() { nums[i], nums[j], nums[k] };
    //                     target.Sort();
    //                     var targetStr = string.Join(",", target);
    //                     if (!filter.Contains(targetStr))
    //                     {
    //                         filter.Add(targetStr);
    //                         res.Add(new List<int>() { nums[i], nums[j], nums[k] });
    //                     }
    //                 }
    //             }
    //         }
    //     }
    //
    //     return res;
    // }
}