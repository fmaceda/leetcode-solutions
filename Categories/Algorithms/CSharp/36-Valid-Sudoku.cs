public class Solution
{
  public bool IsValidSudoku(char[][] board)
  {
    var mapping = new Dictionary<string, bool>();
    var rowLength = 9;
    var colLength = 9;

    for (int rowIdx = 0; rowIdx < rowLength; rowIdx++)
    {
      for (int colIdx = 0; colIdx < colLength; colIdx++)
      {
        char curr = board[rowIdx][colIdx];

        if (curr >= '1' && curr <= '9')
        {
          int gridRow = rowIdx / 3;
          int gridCol = colIdx / 3;

          var rowKey = $"row_{rowIdx}_{curr}";
          var colKey = $"col_{colIdx}_{curr}";
          var gridKey = $"grid_{gridRow}_{gridCol}_{curr}";

          if (
              mapping.ContainsKey(rowKey) ||
              mapping.ContainsKey(colKey) ||
              mapping.ContainsKey(gridKey)
          )
          {
            return false;
          }

          mapping.Add(rowKey, true);
          mapping.Add(colKey, true);
          mapping.Add(gridKey, true);
        }
      }
    }

    return true;
  }
}