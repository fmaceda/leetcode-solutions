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
  public ListNode ReverseList(ListNode head)
  {
    if (head == null || head.next == null)
    {
      return head;
    }

    ListNode node = head;
    ListNode prevNode = null;
    ListNode nextNode = node.next;

    while (node != null)
    {
      node.next = prevNode;
      prevNode = node;
      node = nextNode;

      if (nextNode != null)
      {
        nextNode = nextNode.next;
      }
    }

    return prevNode;
  }

  public bool IsPalindrome(ListNode head)
  {
    ListNode slowPrev = head;
    ListNode slowPointer = head;
    ListNode fastPointer = head;

    while (fastPointer != null && fastPointer.next != null)
    {
      slowPrev = slowPointer;
      slowPointer = slowPointer.next;
      fastPointer = fastPointer.next.next;
    }

    var rightList = ReverseList(slowPointer);
    var leftList = head;

    slowPrev.next = null;

    while (leftList != null)
    {
      if (leftList.val != rightList.val)
      {
        return false;
      }
      rightList = rightList.next;
      leftList = leftList.next;
    }

    return true;
  }
}