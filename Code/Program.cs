// See https://aka.ms/new-console-template for more information

using Code.hot100.doublePointer;
using Code.hot100.hashTable;
using Code.hot100.linkList;

var input = new int[] { 1,8,6,2,5,4,8,3,7};
ListNode headA = new(2);
ListNode headB = new(2);
headA.next = headB;

var node1 = new ListNode(4);
var node2 = new ListNode(5);
var node3 = new ListNode(4);
headB.next = node1;
node1.next = node2;
node2.next = node3;
Console.WriteLine(GetIntersectionNode.Solution(headA,headB)); 
