public class Solution
{
  public IList<int> FindClosestElements(int[] arr, int k, int x)
  {
    var left = 0;
    var right = arr.Length - k;

    while (left < right)
    {
      var mid = (left + right) / 2;

      if (x - arr[mid] <= arr[mid + k] - x)
      {
        right = mid;
      }
      else
      {
        left = mid + 1;
      }
    }

    return arr.Skip(left).Take(k).ToList();
  }
}