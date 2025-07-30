/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
  public ListNode DetectCycle(ListNode head)
  {
    var slowPointer = head;
    var fastPointer = head;

    while (fastPointer != null && fastPointer.next != null && fastPointer != slowPointer)
    {
      slowPointer = slowPointer.next;
      fastPointer = fastPointer.next.next;
    }

    if (fastPointer == null)
    {
      return null;
    }

    var copyOfHead = head;

    while (copyOfHead != slowPointer)
    {
      copyOfHead = copyOfHead.next;
      slowPointer = slowPointer.next;
    }

    return copyOfHead;
  }
}