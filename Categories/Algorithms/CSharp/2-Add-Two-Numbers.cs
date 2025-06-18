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
    ListNode solution = new();
    ListNode currentNode = solution;

    int remainder = 0;

    while (l1 != null || l2 != null || remainder != 0)
    {
      int value1 = l1 != null ? l1.val : 0;
      int value2 = l2 != null ? l2.val : 0;

      int total = (value1 + value2 + remainder) % 10;
      remainder = (value1 + value2 + remainder) / 10;

      currentNode.next = new(total, null);
      currentNode = currentNode.next;

      if (l1 != null)
      {
        l1 = l1.next;
      }

      if (l2 != null)
      {
        l2 = l2.next;
      }
    }

    return solution.next;
  }
}