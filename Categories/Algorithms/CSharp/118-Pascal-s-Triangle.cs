public class Solution
{
  public IList<IList<int>> Generate(int numRows)
  {
    var pascalTriangle = new List<IList<int>>();

    // Always it has first row.
    pascalTriangle.Add(new List<int>());
    pascalTriangle[0].Add(1);

    for (int row = 1; row < numRows; row++)
    {
      pascalTriangle.Add(new List<int>());
      pascalTriangle[row].Add(1);

      for (int col = 1; col < pascalTriangle[row - 1].Count; col++)
      {
        pascalTriangle[row].Add(pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col]);
      }

      pascalTriangle[row].Add(1);
    }

    return pascalTriangle;
  }
}