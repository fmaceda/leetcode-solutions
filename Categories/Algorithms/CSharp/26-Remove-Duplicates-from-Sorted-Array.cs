public class Solution
{
  public int RemoveDuplicates(int[] nums)
  {
    int idx = 1;
    int tmpIdx = 1;

    while (tmpIdx < nums.Length)
    {
      if (nums[tmpIdx] != nums[tmpIdx - 1])
      {
        nums[idx] = nums[tmpIdx];
        idx++;
      }

      tmpIdx++;
    }

    return idx;
  }
}