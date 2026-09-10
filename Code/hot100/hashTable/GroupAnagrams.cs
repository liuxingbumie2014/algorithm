namespace Code.hot100.hashTable;

// 49.字母异位词分组
public class GroupAnagrams
{
    public static IList<IList<string>> Solution(string[] strs)
    {
        //字典/Char数组不方便比较是否一致;使用字符串来比较
        // 排序、哈希表
        IList<IList<string>> res = new List<IList<string>>();
        Dictionary<string,List<string>> resDict = new Dictionary<string,List<string>>();
        foreach (var str in strs)
        {
            int[] arr = new int[26];
            foreach (var val in str)
                arr[val - 'a']++;
            var resStr = string.Join(",", arr);

            List<string> list;
            if (!resDict.TryGetValue(resStr,out list))
            {
                list = new();
                resDict.Add(resStr, list);
            }
            list.Add(str);
        }

        foreach (var value in resDict.Values)
            res.Add(value);
    
        return res;
    }
}