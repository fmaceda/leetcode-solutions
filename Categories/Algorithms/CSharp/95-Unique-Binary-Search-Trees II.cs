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
  public IList<TreeNode> GenerateTrees(int n)
  {
    return GenerateSubTrees(1, n);
  }

  public IList<TreeNode> GenerateSubTrees(int start, int end)
  {
    if (start > end)
    {
      return new List<TreeNode>() { null };
    }

    var allSubTrees = new List<TreeNode>();

    for (var idx = start; idx <= end; idx++)
    {
      var leftTrees = GenerateSubTrees(start, idx - 1);
      var rightTrees = GenerateSubTrees(idx + 1, end);

      foreach (var left in leftTrees)
      {
        foreach (var right in rightTrees)
        {
          var subTree = new TreeNode(idx, left, right);
          allSubTrees.Add(subTree);
        }
      }
    }

    return allSubTrees;
  }
}