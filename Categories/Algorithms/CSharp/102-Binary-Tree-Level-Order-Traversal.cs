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
  public IList<IList<int>> LevelOrder(TreeNode root)
  {
    var solution = new List<IList<int>>();
    var toCheck = new Queue<TreeNode>();
    var currIdx = 0;

    if (root != null)
    {
      toCheck.Enqueue(root);
    }

    while (toCheck.Count > 0)
    {
      var totalNodes = toCheck.Count;

      solution.Add(new List<int>());

      while (totalNodes > 0)
      {
        var currNode = toCheck.Dequeue();

        solution[currIdx].Add(currNode.val);

        if (currNode.left != null)
        {
          toCheck.Enqueue(currNode.left);
        }

        if (currNode.right != null)
        {
          toCheck.Enqueue(currNode.right);
        }

        totalNodes--;
      }

      currIdx++;
    }

    return solution;
  }
}