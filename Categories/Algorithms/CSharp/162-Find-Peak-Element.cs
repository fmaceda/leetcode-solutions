public class Solution
{
  public int FindPeakElement(int[] nums)
  {
    long left = 0;
    long right = nums.Length - 1;

    while (left < right)
    {
      long mid = (left + right) / 2;

      if (nums[mid] > nums[mid + 1])
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