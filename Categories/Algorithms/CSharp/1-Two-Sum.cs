public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    Dictionary<int, int> pairsIdx = new();

    int pairNum;
    int currentNum;
    for (int i = 0; i < nums.Length; i++)
    {
      currentNum = nums[i];
      pairNum = target - currentNum;

      if (pairsIdx.ContainsKey(pairNum))
      {
        return [pairsIdx[pairNum], i];
      }

      if (!pairsIdx.ContainsKey(currentNum))
      {
        pairsIdx.Add(currentNum, i);
      }
    }

    return [-1, -1];
  }
}