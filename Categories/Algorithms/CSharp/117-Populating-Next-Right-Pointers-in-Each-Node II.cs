/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution
{
  public Node Connect(Node root)
  {
    if (root == null || (root.left == null && root.right == null))
    {
      return root;
    }

    if (root.left != null && root.right != null)
    {
      root.left.next = root.right;
      root.right.next = GetNextRightNode(root);
    }

    if (root.left == null)
    {
      root.right.next = GetNextRightNode(root);
    }

    if (root.right == null)
    {
      root.left.next = GetNextRightNode(root);
    }

    root.right = Connect(root.right);
    root.left = Connect(root.left);

    return root;
  }

  public Node GetNextRightNode(Node root)
  {
    while (root.next != null)
    {
      if (root.next.left != null)
      {
        return root.next.left;
      }

      if (root.next.right != null)
      {
        return root.next.right;
      }

      root = root.next;
    }

    return null;
  }
}