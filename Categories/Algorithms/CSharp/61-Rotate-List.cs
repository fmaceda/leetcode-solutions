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
  public ListNode RotateRight(ListNode head, int k)
  {
    if (head == null || head.next == null || k == 0)
    {
      return head;
    }

    var node = head;
    ListNode tail = null;

    var counter = 0;

    while (node != null)
    {
      if (node.next == null)
      {
        tail = node;
      }

      counter++;
      node = node.next;
    }

    ListNode prev = null;
    node = head;

    int kComplement = counter - (k % counter);

    if (kComplement == counter || kComplement == 0)
    {
      return head;
    }

    while (kComplement > 0)
    {
      prev = node;
      kComplement--;
      node = node.next;
    }
    prev.next = null;
    tail.next = head;

    return node;
  }
}