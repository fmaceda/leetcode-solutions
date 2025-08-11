public class Solution
{
  public int NumSquares(int n)
  {
    if (n <= 1)
    {
      return n;
    }

    var numsToCheck = new Queue<int>();
    var visited = new HashSet<int>();

    numsToCheck.Enqueue(n);
    visited.Add(n);

    int steps = 0;

    while (numsToCheck.Count > 0)
    {
      var numsAtLevel = numsToCheck.Count;

      for (int idx = 0; idx < numsAtLevel; idx++)
      {
        var currNum = numsToCheck.Dequeue();

        if (currNum == 0)
        {
          return steps;
        }

        for (int num = 1; num * num <= currNum; num++)
        {
          var remainder = currNum - num * num;

          if (!visited.Contains(remainder))
          {
            numsToCheck.Enqueue(remainder);
            visited.Add(remainder);
          }
        }
      }
      steps++;
    }

    return -1;
  }
}