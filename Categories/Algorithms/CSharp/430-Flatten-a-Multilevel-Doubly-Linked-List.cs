/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution
{
  public Node Flatten(Node head)
  {
    var node = head;
    Node nextNode = null;
    Node tmpNode = null;

    while (node != null)
    {
      if (node.child != null)
      {
        tmpNode = node;
        nextNode = node.next;

        node.next = node.child;
        node.child.prev = node;
        node.child = null;

        while (tmpNode != null && tmpNode.next != null)
        {
          tmpNode = tmpNode.next;
        }

        tmpNode.next = nextNode;
        if (nextNode != null)
        {
          nextNode.prev = tmpNode;
        }
      }
      node = node.next;
    }

    return head;
  }
}