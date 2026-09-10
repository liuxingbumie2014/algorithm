// See https://aka.ms/new-console-template for more information

using Code.hot100.hashTable;

var input = new string[] { "bdddddddddd", "bbbbbbbbbbc"};
// var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
var res = GroupAnagrams.Solution(input);
foreach (var strs in res)
{
    Console.WriteLine(string.Join(",",strs));
}
