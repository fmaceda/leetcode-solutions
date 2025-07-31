public class Solution
{
  public int PivotIndex(int[] nums)
  {
    var sums = new int[nums.Length];

    sums[0] = nums[0];

    for (int idx = 1; idx < nums.Length; idx++)
    {
      sums[idx] = nums[idx] + sums[idx - 1];
    }

    if (sums[nums.Length - 1] - sums[0] == 0)
    {
      return 0;
    }

    for (int idx = 1; idx < nums.Length; idx++)
    {
      if (sums[idx - 1] == sums[nums.Length - 1] - sums[idx])
      {
        return idx;
      }
    }

    return -1;
  }
}