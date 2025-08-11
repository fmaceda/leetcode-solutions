public class Solution
{
  public bool CanVisitAllRooms(IList<IList<int>> rooms)
  {
    var visited = new HashSet<int>();
    var toCheck = new Queue<int>();

    toCheck.Enqueue(0);

    while (toCheck.Count > 0)
    {
      var curr = toCheck.Dequeue();
      visited.Add(curr);

      foreach (var neighbor in rooms[curr])
      {
        if (!visited.Contains(neighbor))
        {
          toCheck.Enqueue(neighbor);
        }
      }
    }

    return visited.Count == rooms.Count;
  }
}