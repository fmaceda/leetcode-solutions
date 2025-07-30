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
  public ListNode OddEvenList(ListNode head)
  {
    // List with 0, 1 or 2 nodes should not require any update.
    if (head == null || head.next == null || head.next.next == null)
    {
      return head;
    }

    var oddNode = head;
    var evenNode = head.next;
    var evenNodeCopy = head.next;

    var node = head.next.next;
    var isEven = false;

    while (node != null)
    {
      if (isEven)
      {
        evenNode.next = node;
        evenNode = evenNode.next;
      }
      else
      {
        oddNode.next = node;
        oddNode = oddNode.next;
      }
      node = node.next;
      isEven = !isEven;
    }

    oddNode.next = evenNodeCopy;
    evenNode.next = null;

    return head;
  }
}