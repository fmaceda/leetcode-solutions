public class Solution
{
  public int SplitArray(int[] nums, int k)
  {
    var low = nums.Max();
    var high = nums.Sum();

    while (low <= high)
    {
      var mid = (high + low) / 2;

      if (IsPossibleToSplit(nums, mid, k))
      {
        high = mid - 1;
      }
      else
      {
        low = mid + 1;
      }
    }

    return low;
  }

  public bool IsPossibleToSplit(int[] nums, int maxSum, int maxArrays)
  {
    var currCount = 0;
    var arraysCount = 1;

    foreach (int num in nums)
    {
      if (currCount + num <= maxSum)
      {
        currCount += num;
      }
      else
      {
        currCount = num;
        arraysCount++;
      }
    }

    return arraysCount <= maxArrays;
  }
}