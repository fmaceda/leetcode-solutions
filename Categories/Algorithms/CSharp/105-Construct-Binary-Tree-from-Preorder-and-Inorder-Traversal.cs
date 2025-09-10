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
  public TreeNode BuildTree(int[] preorder, int[] inorder)
  {
    return BuildTreeUtil(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
  }

  public TreeNode BuildTreeUtil(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd)
  {
    if (preStart > preEnd || inStart > inEnd)
    {
      return null;
    }

    var rootValue = preorder[preStart];
    var root = new TreeNode(rootValue);
    var rootIdx = -1;

    for (var idx = inStart; idx <= inEnd; idx++)
    {
      if (inorder[idx] == rootValue)
      {
        rootIdx = idx;
        break;
      }
    }

    var leftSize = rootIdx - inStart;
    var rightSize = inEnd - rootIdx;

    root.left = BuildTreeUtil(preorder, preStart + 1, preStart + leftSize, inorder, inStart, rootIdx - 1);
    root.right = BuildTreeUtil(preorder, preStart + leftSize + 1, preEnd, inorder, rootIdx + 1, inEnd);

    return root;
  }
}