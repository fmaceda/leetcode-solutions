public class Solution
{
  public bool ValidMountainArray(int[] arr)
  {
    var climbing = true;

    var up = false;
    var down = false;

    for (int idx = 1; idx < arr.Length; idx++)
    {
      if (arr[idx] > arr[idx - 1])
      {
        if (climbing)
        {
          up = true;
        }

        if (down)
        {
          return false;
        }
      }
      else if (arr[idx] < arr[idx - 1])
      {
        down = true;
      }
      else
      {
        return false;
      }
    }

    return up && down;
  }
}