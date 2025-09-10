/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution
{
  public Node CloneGraph(Node node)
  {
    if (node == null)
    {
      return null;
    }

    var cloned = new Node(node.val);
    var visited = new HashSet<int>();
    var mapping = new Dictionary<int, Node>();

    mapping.Add(1, cloned);

    Traverse(node, cloned, visited, mapping);

    return cloned;
  }

  public void Traverse(Node original, Node copy, HashSet<int> visited, Dictionary<int, Node> mapping)
  {
    visited.Add(original.val);

    for (int neighborIdx = 0; neighborIdx < original.neighbors.Count; neighborIdx++)
    {
      var nodeVal = original.neighbors[neighborIdx].val;

      if (!visited.Contains(nodeVal))
      {
        var newNode = new Node(nodeVal);

        newNode.neighbors.Add(copy);
        copy.neighbors.Add(newNode);

        mapping.Add(nodeVal, newNode);

        Traverse(original.neighbors[neighborIdx], copy.neighbors[neighborIdx], visited, mapping);
      }
      else if (!copy.neighbors.Contains(mapping[nodeVal]))
      {
        copy.neighbors.Add(mapping[nodeVal]);
        mapping[nodeVal].neighbors.Add(copy);
      }
    }
  }
}