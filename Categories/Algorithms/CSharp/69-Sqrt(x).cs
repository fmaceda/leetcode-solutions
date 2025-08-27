public class Solution
{
  public int MySqrt(int x)
  {
    if (x <= 1)
    {
      return x;
    }

    var left = 0;
    var right = Math.Min(x, 50000);

    while (left <= right)
    {
      var mid = (left + right) / 2;

      if (mid == 0)
      {
        return 0;
      }

      if (mid == x / mid)
      {
        return mid;
      }

      if (mid > x / mid)
      {
        right = mid - 1;
      }

      if (mid < x / mid)
      {
        left = mid + 1;
      }
    }


    return left - 1;
  }
}