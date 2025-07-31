public class Solution
{
  public IList<int> GetRow(int rowIndex)
  {
    var solution = new List<int>();
    solution.Add(1);

    while (rowIndex > 0)
    {
      var tmp = solution[0];

      for (int idx = 1; idx < solution.Count; idx++)
      {
        (solution[idx], tmp) = (tmp + solution[idx], solution[idx]);

      }

      solution.Add(1);
      rowIndex--;
    }

    return solution;
  }
}