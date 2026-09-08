// See https://aka.ms/new-console-template for more information

using Code.hot100;
using Code.Sort;

var nums = new[] { 2, 7, 11, 15 };
var target = 9;
var res = TwoSum.Solution(nums,target);
Console.WriteLine(string.Join(",", res));