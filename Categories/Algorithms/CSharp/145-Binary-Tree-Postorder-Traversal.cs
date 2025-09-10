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
  public void Traverse(TreeNode node, IList<int> postOrder)
  {
    if (node == null)
    {
      return;
    }

    Traverse(node.left, postOrder);
    Traverse(node.right, postOrder);

    postOrder.Add(node.val);
  }

  public IList<int> PostorderTraversal(TreeNode root)
  {
    var postOrder = new List<int>();

    Traverse(root, postOrder);

    return postOrder;
  }
}