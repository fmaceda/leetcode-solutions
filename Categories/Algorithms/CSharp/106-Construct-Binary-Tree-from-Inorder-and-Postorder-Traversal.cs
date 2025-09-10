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
  public TreeNode BuildTree(int[] inorder, int[] postorder)
  {
    return BuildTreeUtil(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1);
  }

  public TreeNode BuildTreeUtil(int[] inorder, int inStart, int inEnd, int[] postorder, int poStart, int poEnd)
  {
    if (inStart > inEnd || poStart > poEnd)
    {
      return null;
    }

    var rootVal = postorder[poEnd];
    var root = new TreeNode(rootVal);
    var rootIdx = -1;

    for (var idx = inStart; idx <= inEnd; idx++)
    {
      if (inorder[idx] == rootVal)
      {
        rootIdx = idx;
        break;
      }
    }

    var leftSize = rootIdx - inStart;
    var rightSize = inEnd - rootIdx;

    root.left = BuildTreeUtil(inorder, inStart, rootIdx - 1, postorder, poStart, poStart + leftSize - 1);
    root.right = BuildTreeUtil(inorder, rootIdx + 1, inEnd, postorder, poStart + leftSize, poEnd - 1);

    return root;
  }
}