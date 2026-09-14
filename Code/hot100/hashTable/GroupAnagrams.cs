// 49.字母异位词分组
// 给你一个字符串数组，请你将 字母异位词 组合在一起。可以按任意顺序返回结果列表。
// 示例 1:
// 输入: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
// 输出: [["bat"],["nat","tan"],["ate","eat","tea"]]
// 解释：
// 在 strs 中没有字符串可以通过重新排列来形成 "bat"。
// 字符串 "nat" 和 "tan" 是字母异位词，因为它们可以重新排列以形成彼此。
// 字符串 "ate" ，"eat" 和 "tea" 是字母异位词，因为它们可以重新排列以形成彼此。
//
// 示例 2:
// 输入: strs = [""]
// 输出: [[""]]
//     
// 示例 3:
// 输入: strs = ["a"]
// 输出: [["a"]]

namespace Code.hot100.hashTable;

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