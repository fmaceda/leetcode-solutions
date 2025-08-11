public class Solution
{
  public void BFS(int[][] grid, int[][] distance, int rowIdx, int colIdx, int rows, int cols)
  {
    var toCheck = new Queue<(int row, int col)>();
    toCheck.Enqueue((rowIdx, colIdx));

    distance[rowIdx][colIdx] = 0;

    while (toCheck.Count > 0)
    {
      var curr = toCheck.Dequeue();

      if (curr.row - 1 >= 0 && grid[curr.row - 1][curr.col] == 1) // Up
      {
        if (distance[curr.row - 1][curr.col] > distance[curr.row][curr.col] + 1)
        {
          distance[curr.row - 1][curr.col] = distance[curr.row][curr.col] + 1;
          toCheck.Enqueue((curr.row - 1, curr.col));
        }
      }

      if (curr.row + 1 < rows && grid[curr.row + 1][curr.col] == 1) // Down
      {
        if (distance[curr.row + 1][curr.col] > distance[curr.row][curr.col] + 1)
        {
          distance[curr.row + 1][curr.col] = distance[curr.row][curr.col] + 1;
          toCheck.Enqueue((curr.row + 1, curr.col));
        }
      }

      if (curr.col - 1 >= 0 && grid[curr.row][curr.col - 1] == 1) // Left
      {
        if (distance[curr.row][curr.col - 1] > distance[curr.row][curr.col] + 1)
        {
          distance[curr.row][curr.col - 1] = distance[curr.row][curr.col] + 1;
          toCheck.Enqueue((curr.row, curr.col - 1));
        }
      }

      if (curr.col + 1 < cols && grid[curr.row][curr.col + 1] == 1) // Right
      {
        if (distance[curr.row][curr.col + 1] > distance[curr.row][curr.col] + 1)
        {
          distance[curr.row][curr.col + 1] = distance[curr.row][curr.col] + 1;
          toCheck.Enqueue((curr.row, curr.col + 1));
        }
      }
    }
  }

  public int[][] UpdateMatrix(int[][] mat)
  {
    var rows = mat.Length;
    var cols = mat[0].Length;

    var distance = new int[rows][];

    for (int rowIdx = 0; rowIdx < rows; rowIdx++)
    {
      distance[rowIdx] = new int[cols];

      for (int colIdx = 0; colIdx < cols; colIdx++)
      {
        distance[rowIdx][colIdx] = int.MaxValue;
      }
    }

    for (int rowIdx = 0; rowIdx < rows; rowIdx++)
    {
      for (int colIdx = 0; colIdx < cols; colIdx++)
      {
        if (mat[rowIdx][colIdx] == 0)
        {
          BFS(mat, distance, rowIdx, colIdx, rows, cols);
        }
      }
    }
    return distance;
  }
}