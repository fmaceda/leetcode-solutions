/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution
{
  public Node CopyRandomList(Node head)
  {
    var randomMapping = new Dictionary<Node, List<Node>>();

    var oldHead = head;
    Node newHead = null;
    Node node = null;

    while (oldHead != null)
    {
      if (newHead == null)
      {
        newHead = new Node(oldHead.val);
        node = newHead;
      }
      else
      {
        node.next = new Node(oldHead.val);
        node = node.next;
      }

      if (oldHead.random != null)
      {
        if (!randomMapping.ContainsKey(oldHead.random))
        {
          randomMapping.Add(oldHead.random, new List<Node>());
        }
        randomMapping[oldHead.random].Add(node);
      }

      oldHead = oldHead.next;
    }

    oldHead = head;
    node = newHead;

    while (oldHead != null)
    {
      if (randomMapping.ContainsKey(oldHead))
      {
        if (randomMapping.TryGetValue(oldHead, out List<Node> sources))
        {

          foreach (var source in sources)
          {
            source.random = node;
          }
        }
      }

      oldHead = oldHead.next;
      node = node.next;
    }

    return newHead;
  }
}