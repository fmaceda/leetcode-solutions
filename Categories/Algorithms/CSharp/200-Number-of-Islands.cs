public class Solution
{
  void Traverse(int row, int col, char[][] grid, int rows, int cols)
  {
    var toVisit = new Queue<(int row, int col)>();

    toVisit.Enqueue((row, col));

    while (toVisit.Count > 0)
    {
      var curr = toVisit.Dequeue();

      if (grid[curr.row][curr.col] == '1') // It's land
      {
        if (curr.col - 1 >= 0 && grid[curr.row][curr.col - 1] != '0') // Going left
        {
          toVisit.Enqueue((curr.row, curr.col - 1));
        }

        if (curr.row - 1 >= 0 && grid[curr.row - 1][curr.col] != '0') // Going top
        {
          toVisit.Enqueue((curr.row - 1, curr.col));
        }

        if (curr.col + 1 < cols && grid[curr.row][curr.col + 1] != '0') // Going right
        {
          toVisit.Enqueue((curr.row, curr.col + 1));
        }

        if (curr.row + 1 < rows && grid[curr.row + 1][curr.col] != '0') // Going bottom
        {
          toVisit.Enqueue((curr.row + 1, curr.col));
        }

        grid[curr.row][curr.col] = '0';
      }
    }
  }

  public int NumIslands(char[][] grid)
  {
    int rows = grid.Length;
    int cols = grid[0].Length;
    int islands = 0;

    for (int row = 0; row < rows; row++)
    {
      for (int col = 0; col < cols; col++)
      {
        if (grid[row][col] == '1') // It's land
        {
          Traverse(row, col, grid, rows, cols);
          islands++;
        }
      }
    }

    return islands;
  }
}