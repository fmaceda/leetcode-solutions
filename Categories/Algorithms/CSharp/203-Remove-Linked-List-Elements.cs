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
  public ListNode RemoveElements(ListNode head, int val)
  {
    ListNode prevNode = null;
    ListNode currNode = head;

    while (currNode != null)
    {
      if (currNode.val == val && prevNode != null)
      {
        prevNode.next = currNode.next;
        currNode = currNode.next;
      }
      else
      {
        prevNode = currNode;
        currNode = currNode.next;
      }
    }

    if (head != null && head.val == val)
    {
      head = head.next;
    }

    return head;
  }
}