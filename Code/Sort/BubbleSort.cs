namespace Code.Sort;

public class BubbleSort
{
    public static int[] Sort(int[] array)
    {
        //冒泡
        //比较多少轮
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] < array[j + 1])
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }

        return array;
    }
}