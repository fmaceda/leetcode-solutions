/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec
{

  // Encodes a tree to a single string.
  public string serialize(TreeNode root)
  {
    var result = new List<string>();

    SerializeUtil(root, result);

    return string.Join(",", result);
  }

  private void SerializeUtil(TreeNode node, List<string> result)
  {
    if (node == null)
    {
      result.Add("N");
      return;
    }

    result.Add(node.val.ToString());

    SerializeUtil(node.left, result);
    SerializeUtil(node.right, result);
  }

  // Decodes your encoded data to tree.
  public TreeNode deserialize(string data)
  {
    var values = data.Split(',');
    var toCheck = new Queue<string>();

    foreach (string val in values)
    {
      toCheck.Enqueue(val);
    }

    return DeserializeUtil(toCheck);
  }

  private TreeNode DeserializeUtil(Queue<string> toCheck)
  {
    if (toCheck.TryDequeue(out string item))
    {
      if (item == "N")
      {
        return null;
      }

      var node = new TreeNode(int.Parse(item));

      node.left = DeserializeUtil(toCheck);
      node.right = DeserializeUtil(toCheck);

      return node;
    }

    return null;
  }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));