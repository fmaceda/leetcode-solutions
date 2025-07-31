public class Solution
{
  public IList<int> SpiralOrder(int[][] matrix)
  {
    var path = new List<int>();

    var totalRows = matrix.Length;
    var totalCols = matrix[0].Length;

    var minRow = 0;
    var maxRow = totalRows - 1;
    var minCol = 0;
    var maxCol = totalCols - 1;

    var row = 0;
    var col = 0;

    var rowStep = 0;
    var colStep = 1;

    while (path.Count != totalRows * totalCols)
    {
      path.Add(matrix[row][col]);

      // From left to right
      if (rowStep == 0 && colStep == 1)
      {
        if (col < maxCol)
        {
          col++;
        }
        else
        {
          rowStep = 1;
          colStep = 0;
          row++;
          minRow++;
        }
      }

      // From top to bottom
      else if (rowStep == 1 && colStep == 0)
      {
        if (row < maxRow)
        {
          row++;
        }
        else
        {
          rowStep = 0;
          colStep = -1;
          col--;
          maxCol--;
        }
      }

      // From right to left
      else if (rowStep == 0 && colStep == -1)
      {
        if (col > minCol)
        {
          col--;
        }
        else
        {
          rowStep = -1;
          colStep = 0;
          row--;
          maxRow--;
        }
      }

      // From bottom to top
      else if (rowStep == -1 && colStep == 0)
      {
        if (row > minRow)
        {
          row--;
        }
        else
        {
          rowStep = 0;
          colStep = 1;
          col++;
          minCol++;
        }
      }
    }

    return path;
  }
}