/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
  public ListNode MiddleNode(ListNode head)
  {
    var node = head;
    var midNode = head;
    int counter = 0;

    while (node != null)
    {
      counter++;
      node = node.next;
    }

    counter /= 2;

    while (counter > 0)
    {
      counter--;
      midNode = midNode.next;
    }

    return midNode;
  }
}