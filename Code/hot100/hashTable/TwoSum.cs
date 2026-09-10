namespace Code.hot100.hashTable;

public class TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        //暴力
        // for (int i = 0; i < nums.Length - 1; i++)
        // {
        //     for (int j = i + 1; j < nums.Length; j++)
        //     {
        //         if (nums[i] + nums[j] == target)
        //             return new int[] { i, j };
        //     }
        // }

        //哈希表,key 为值、value为index
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var value = target - nums[i];
            if (dict.ContainsKey(value))
                return new int[] { i, dict[value] };
            else
                dict.TryAdd(nums[i], i);
        }
        return [];
    }
}