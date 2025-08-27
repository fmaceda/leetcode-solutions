/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
  public int FirstBadVersion(int n)
  {
    long left = 0;
    long right = n;

    while (left < right)
    {
      long mid = (left + right) / 2;

      if (IsBadVersion((int)mid))
      {
        right = mid;
      }
      else
      {
        left = mid + 1;
      }
    }

    return (int)left;

  }
}