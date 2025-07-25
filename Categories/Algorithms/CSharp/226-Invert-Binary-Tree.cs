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
  public TreeNode InvertTree(TreeNode root)
  {
    var nodesToCheck = new Queue<TreeNode>();
    nodesToCheck.Enqueue(root);

    while (nodesToCheck.Count > 0)
    {
      var currNode = nodesToCheck.Dequeue();

      if (currNode != null)
      {
        (currNode.right, currNode.left) = (currNode.left, currNode.right);
        
        if (currNode.left != null)
        {
          nodesToCheck.Enqueue(currNode.left);
        }

        if (currNode.right != null)
        {
          nodesToCheck.Enqueue(currNode.right);
        }
      }
    }

    return root;
  }
}