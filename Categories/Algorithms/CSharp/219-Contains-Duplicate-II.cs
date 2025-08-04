public class Solution
{
  public bool ContainsNearbyDuplicate(int[] nums, int k)
  {
    var pairs = new Dictionary<int, (int first, int second)>();

    for (int idx = 0; idx < nums.Length; idx++)
    {
      var currNum = nums[idx];
      if (!pairs.ContainsKey(currNum))
      {
        pairs.Add(currNum, (idx, -1));
      }
      else
      {
        if (pairs[currNum].second == -1)
        {
          pairs[currNum] = (pairs[currNum].first, idx);
        }
        else if (Math.Abs(pairs[currNum].first - idx) > Math.Abs(pairs[currNum].second - idx))
        {
          pairs[currNum] = (idx, pairs[currNum].second);
        }
        else
        {
          pairs[currNum] = (pairs[currNum].first, idx);
        }

        if (Math.Abs(pairs[currNum].first - pairs[currNum].second) <= k)
        {
          return true;
        }
      }
    }

    return false;
  }
}