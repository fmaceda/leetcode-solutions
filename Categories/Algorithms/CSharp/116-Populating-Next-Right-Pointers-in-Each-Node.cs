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
    if (root == null || root.left == null || root.right == null)
    {
      return root;
    }

    var left = Connect(root.left);
    var right = Connect(root.right);

    DeepConnect(left, right);

    return root;
  }

  public void DeepConnect(Node left, Node right)
  {
    if (left == null || right == null)
    {
      return;
    }

    left.next = right;
    DeepConnect(left.right, right.left);
  }
}