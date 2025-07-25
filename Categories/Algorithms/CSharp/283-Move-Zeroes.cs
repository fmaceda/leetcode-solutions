public class Solution
{
  public void MoveZeroes(int[] nums)
  {
    int nonZeroIdx = 0;
    int zeroCounter = 0;

    for (int idx = 0; idx < nums.Length; idx++)
    {
      if (nums[idx] != 0)
      {
        nums[nonZeroIdx] = nums[idx];
        nonZeroIdx++;
      }
    }

    while (nonZeroIdx < nums.Length)
    {
      nums[nonZeroIdx] = 0;
      nonZeroIdx++;
    }
  }
}