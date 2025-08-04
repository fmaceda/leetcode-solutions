public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    var pairsIdx = new Dictionary<int, int>();

    int pairNum;
    int currentNum;
    for (int idx = 0; idx < nums.Length; idx++)
    {
      currentNum = nums[idx];
      pairNum = target - currentNum;

      if (pairsIdx.ContainsKey(pairNum))
      {
        return [pairsIdx[pairNum], idx];
      }

      if (!pairsIdx.ContainsKey(currentNum))
      {
        pairsIdx.Add(currentNum, idx);
      }
    }

    return [-1, -1];
  }
}