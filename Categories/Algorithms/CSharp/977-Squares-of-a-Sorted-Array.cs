public class Solution
{
  public int[] SortedSquares(int[] nums)
  {
    var sorted = new int[nums.Length];

    for (int idx = 0; idx < nums.Length; idx++)
    {
      nums[idx] = nums[idx] * nums[idx];
    }

    int higherIdx = nums.Length - 1;
    int lowerIdx = 0;
    int writerIdx = nums.Length - 1;

    while (lowerIdx <= higherIdx)
    {
      if (nums[lowerIdx] > nums[higherIdx])
      {
        sorted[writerIdx] = nums[lowerIdx];
        lowerIdx++;
      }
      else
      {
        sorted[writerIdx] = nums[higherIdx];
        higherIdx--;
      }
      writerIdx--;
    }

    return sorted;
  }
}