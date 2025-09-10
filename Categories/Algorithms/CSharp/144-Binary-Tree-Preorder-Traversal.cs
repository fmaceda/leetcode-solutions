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
  public void Traverse(TreeNode node, IList<int> preOrder)
  {
    if (node == null)
    {
      return;
    }

    preOrder.Add(node.val);

    Traverse(node.left, preOrder);
    Traverse(node.right, preOrder);
  }

  public IList<int> PreorderTraversal(TreeNode root)
  {
    var preOrder = new List<int>();

    Traverse(root, preOrder);

    return preOrder;
  }
}