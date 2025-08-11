public class Solution
{
  public int[][] FloodFill(int[][] image, int sr, int sc, int color)
  {
    int previousColor = image[sr][sc];

    if (previousColor == color)
    {
      return image;
    }

    int rows = image.Length;
    int cols = image[0].Length;

    var toCheck = new Queue<(int row, int col)>();

    toCheck.Enqueue((sr, sc));

    while (toCheck.Count > 0)
    {
      var curr = toCheck.Dequeue();

      if (image[curr.row][curr.col] == previousColor)
      {
        image[curr.row][curr.col] = color;

        if (curr.row - 1 >= 0) // Up
        {
          toCheck.Enqueue((curr.row - 1, curr.col));
        }

        if (curr.row + 1 < rows) // Down
        {
          toCheck.Enqueue((curr.row + 1, curr.col));
        }

        if (curr.col - 1 >= 0) // Left
        {
          toCheck.Enqueue((curr.row, curr.col - 1));
        }

        if (curr.col + 1 < cols) // Right
        {
          toCheck.Enqueue((curr.row, curr.col + 1));
        }
      }
    }

    return image;
  }
}