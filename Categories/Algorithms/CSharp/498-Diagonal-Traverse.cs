public class Solution
{
  public int[] FindDiagonalOrder(int[][] mat)
  {
    var m = mat.Length;
    var n = mat[0].Length;

    var row = 0;
    var col = 0;

    var toBottom = false;

    var sol = new int[n * m];
    var idx = 0;

    while (!(row == m && col == n))
    {
      if (row < m && col < n)
      {
        sol[idx] = mat[row][col];
        idx++;
      }

      if (row == 0 && !toBottom)
      {
        col++;
        toBottom = true;
      }
      else if (col == 0 && toBottom)
      {

        row++;
        toBottom = false;
      }
      else
      {
        if (toBottom)
        {
          col--;
          row++;
        }
        else
        {
          col++;
          row--;
        }
      }
    }

    return sol;
  }
}