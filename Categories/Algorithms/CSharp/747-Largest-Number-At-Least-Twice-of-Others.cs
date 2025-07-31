public class Solution
{
  public int DominantIndex(int[] nums)
  {
    int largestIdx = 0;
    int secondLargestIdx = -1;

    for (int idx = 1; idx < nums.Length; idx++)
    {
      if (nums[idx] > nums[largestIdx])
      {
        secondLargestIdx = largestIdx;
        largestIdx = idx;
      }
      else if (secondLargestIdx == -1 || (secondLargestIdx != -1 && nums[idx] > nums[secondLargestIdx]))
      {
        secondLargestIdx = idx;
      }
    }

    return nums[largestIdx] >= nums[secondLargestIdx] * 2 ? largestIdx : -1;
  }
}