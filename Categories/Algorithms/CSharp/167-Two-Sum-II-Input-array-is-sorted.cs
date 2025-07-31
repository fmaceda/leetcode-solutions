public class Solution
{
  public int[] TwoSum(int[] numbers, int target)
  {
    var lowerIdx = 0;
    var upperIdx = numbers.Length - 1;

    while (lowerIdx < upperIdx)
    {
      if (numbers[lowerIdx] + numbers[upperIdx] == target)
      {
        return new int[] { lowerIdx + 1, upperIdx + 1 };
      }

      if (numbers[lowerIdx] + numbers[upperIdx] < target)
      {
        lowerIdx++;
      }

      if (numbers[lowerIdx] + numbers[upperIdx] > target)
      {
        upperIdx--;
      }
    }

    return new int[] { -1, -1 };
  }
}