public class Node(string index, int steps = -1)
{
  public string Index = index;
  public int Steps = steps;
}

public class Solution
{
  private string GetNextCombination(string currIndex, int lockIdx, int direction)
  {
    var index = currIndex.ToCharArray();
    int digit = (index[lockIdx] - '0' + direction + 10) % 10;

    index[lockIdx] = (char)(digit + '0');

    return new string(index);
  }

  private int BFS(Node startNode, Node targetNode, HashSet<string> deadendNodes)
  {
    var nodesToCheck = new Queue<Node>();
    var visitedNodes = new HashSet<string>();
    nodesToCheck.Enqueue(startNode);
    visitedNodes.Add(startNode.Index);

    while (nodesToCheck.Count > 0)
    {
      var currNode = nodesToCheck.Dequeue();
      if (deadendNodes.Contains(currNode.Index))
      {
        continue;
      }

      if (currNode.Index == targetNode.Index)
      {
        return currNode.Steps;
      }

      for (int lockIdx = 0; lockIdx < 4; lockIdx++)
      {
        for (int direction = -1; direction <= 1; direction += 2)
        {
          string nextCombination = GetNextCombination(currNode.Index, lockIdx, direction);

          if (!visitedNodes.Contains(nextCombination) && !deadendNodes.Contains(nextCombination))
          {
            nodesToCheck.Enqueue(new Node(nextCombination, currNode.Steps + 1));
            visitedNodes.Add(nextCombination);
          }
        }
      }
    }

    return -1;
  }

  public int OpenLock(string[] deadends, string target)
  {
    var deadendNodes = new HashSet<string>(deadends);
    var startNode = new Node("0000", 0);
    var targetNode = new Node(target);

    return BFS(startNode, targetNode, deadendNodes);
  }
}