public class Solution
{
  public int SmallestDistancePair(int[] nums, int k)
  {
    Array.Sort(nums);

    var minDistance = 0;
    var maxDistance = nums[^1] - nums[0];

    while (minDistance < maxDistance)
    {
      var midDistance = (minDistance + maxDistance) / 2;
      var pairsCount = CountPairs(nums, midDistance);

      if (pairsCount < k)
      {
        minDistance = midDistance + 1;
      }
      else
      {
        maxDistance = midDistance;
      }

    }

    return minDistance;
  }

  public int CountPairs(int[] nums, int distance)
  {
    var pairsCount = 0;
    var left = 0;
    var right = 1;

    while (right < nums.Length)
    {
      if (nums[right] - nums[left] > distance)
      {
        left++;
      }
      else
      {
        pairsCount += (right - left);
        right++;
      }
    }

    return pairsCount;
  }
}