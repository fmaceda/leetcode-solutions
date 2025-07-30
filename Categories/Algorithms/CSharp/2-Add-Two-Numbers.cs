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
  public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
  {
    var node1 = l1;
    var node2 = l2;
    var head = l1;

    int sum = 0;
    int remainder = 0;

    while (node1 != null && node2 != null)
    {
      sum = (node1.val + node2.val + remainder) % 10;
      remainder = (node1.val + node2.val + remainder) / 10;

      node1.val = sum;

      if (node1.next == null && node2.next == null)
      {
        break;
      }
      else
      {
        node1.next = node1.next ?? new ListNode(0);
        node2.next = node2.next ?? new ListNode(0);
      }

      node1 = node1.next;
      node2 = node2.next;
    }

    if (remainder > 0)
    {
      node1.next = new ListNode(remainder);
    }

    return head;
  }
}