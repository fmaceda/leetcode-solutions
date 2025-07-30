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
  public ListNode MergeTwoLists(ListNode list1, ListNode list2)
  {
    if (list1 == null)
    {
      return list2;
    }

    if (list2 == null)
    {
      return list1;
    }

    var node1 = list1;
    var node2 = list2;
    ListNode node3 = null;
    ListNode mergedNode = null;
    ListNode tmpNode = null;

    while (node1 != null && node2 != null)
    {
      if (node1.val < node2.val)
      {
        tmpNode = node1;
        node1 = node1.next;
      }
      else
      {
        tmpNode = node2;
        node2 = node2.next;
      }

      if (mergedNode != null)
      {
        mergedNode.next = tmpNode;
        mergedNode = mergedNode.next;
      }
      else
      {
        mergedNode = tmpNode;
        node3 = tmpNode;
      }
    }

    tmpNode = node1 ?? node2;

    while (tmpNode != null)
    {
      mergedNode.next = tmpNode;
      mergedNode = mergedNode.next;
      tmpNode = tmpNode.next;
    }

    return node3;
  }
}