/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
  public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
  {
    var nodeA = headA;
    var nodeB = headB;

    while (nodeA != nodeB)
    {
      nodeA = nodeA != null ? nodeA.next : headB;
      nodeB = nodeB != null ? nodeB.next : headA;
    }

    return nodeA;
  }
}