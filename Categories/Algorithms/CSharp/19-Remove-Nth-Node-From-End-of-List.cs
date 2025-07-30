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
  public ListNode RemoveNthFromEnd(ListNode head, int n)
  {
    var slowPointer = head;
    var fastPointer = head;

    int diffBetweenNodes = 0;

    while (fastPointer != null)
    {
      if (diffBetweenNodes > n)
      {
        slowPointer = slowPointer.next;
      }
      fastPointer = fastPointer.next;
      diffBetweenNodes++;
    }

    if (slowPointer == head && diffBetweenNodes <= n)
    {
      head = head.next;
    }
    else
    {
      slowPointer.next = slowPointer.next.next;
    }

    return head;
  }
}