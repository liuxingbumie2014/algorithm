namespace Code.hot100.doublePointer;

public class MoveZeroes
{
    public static void Solution(int[] nums)
    {
        //快慢指针 
        int left = 0;//零指针
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] != 0)
            {
                (nums[right], nums[left]) = (nums[left], nums[right]);
                left++;
            }
        }

        Console.WriteLine(string.Join(",", nums));
    }
}