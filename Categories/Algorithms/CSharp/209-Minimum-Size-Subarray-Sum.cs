public class Solution
{
  public int MinSubArrayLen(int target, int[] nums)
  {
    var sums = new int[nums.Length];
    sums[0] = nums[0];

    for (int idx = 1; idx < nums.Length; idx++)
    {
      sums[idx] = sums[idx - 1] + nums[idx];
    }

    var leftIdx = 0;
    var rightIdx = 0;
    var maxIdx = nums.Length - 1;
    var minLength = int.MaxValue;

    while (leftIdx <= maxIdx && rightIdx <= maxIdx)
    {
      var rangeSum = sums[rightIdx] - (leftIdx > 0 ? sums[leftIdx - 1] : 0);

      if (rangeSum >= target)
      {
        minLength = Math.Min(minLength, rightIdx - leftIdx + 1);
        leftIdx++;
      }
      else
      {
        rightIdx++;
      }
    }


    return minLength == int.MaxValue ? 0 : minLength;
  }
}