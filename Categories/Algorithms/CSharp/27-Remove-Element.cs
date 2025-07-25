public class Solution
{
  public int RemoveElement(int[] nums, int val)
  {
    int idx = 0;
    int tmpIdx = 0;

    while (tmpIdx < nums.Length)
    {
      if (nums[tmpIdx] != val)
      {
        nums[idx] = nums[tmpIdx];
        idx++;
      }

      tmpIdx++;
    }

    return idx;
  }
}