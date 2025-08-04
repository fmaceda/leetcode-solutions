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
  public string TraverseTree(TreeNode node, Dictionary<string, int> mapping, List<TreeNode> solution)
  {
    if (node == null)
    {
      return "*";
    }

    var key = $"{node.val},{TraverseTree(node.left, mapping, solution)},{TraverseTree(node.right, mapping, solution)}";
    if (!mapping.ContainsKey(key))
    {
      mapping.Add(key, 0);
    }

    mapping[key]++;

    if (mapping[key] == 2)
    {
      solution.Add(node);
    }
    return key;
  }

  public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
  {
    var solution = new List<TreeNode>();
    var mapping = new Dictionary<string, int>();

    TraverseTree(root, mapping, solution);

    return solution;
  }
}