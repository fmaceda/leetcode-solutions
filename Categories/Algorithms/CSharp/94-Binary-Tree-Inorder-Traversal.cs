/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
  void Traverse(TreeNode node, List<int> inOrder)
  {
    if (node == null)
    {
      return;
    }

    Traverse(node.left, inOrder);
    inOrder.Add(node.val);
    Traverse(node.right, inOrder);
  }

  public IList<int> InorderTraversal(TreeNode root)
  {
    var inOrder = new List<int>();

    Traverse(root, inOrder);

    return inOrder;
  }
}