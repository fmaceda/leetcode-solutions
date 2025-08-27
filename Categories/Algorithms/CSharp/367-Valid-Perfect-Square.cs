public class Solution
{
  public bool IsPerfectSquare(int num)
  {
    long left = 0;
    long right = Math.Min(num, 50000); // Only compare between 0 and square root of max limit.

    while (left <= right)
    {
      long mid = (left + right) / 2;

      if (mid * mid == (long)num)
      {
        return true;
      }

      if (mid * mid < (long)num)
      {
        left = mid + 1;
      }

      if (mid * mid > (long)num)
      {
        right = mid - 1;
      }
    }

    return false;
  }
}