public class Solution
{
  public int[] RunningSum(int[] nums)
  {
    var sums = new int[nums.Length];

    sums[0] = nums[0];

    for (int idx = 1; idx < nums.Length; idx++)
    {
      sums[idx] = nums[idx] + sums[idx - 1];
    }

    return sums;
  }
}