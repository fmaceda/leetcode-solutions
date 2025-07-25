public class Solution
{
  public int FindMaxConsecutiveOnes(int[] nums)
  {
    int maxOnes = 0;
    int counter = 0;

    foreach (int num in nums)
    {
      if (num == 1)
      {
        counter++;
      }
      else
      {
        maxOnes = Math.Max(maxOnes, counter);
        counter = 0;
      }
    }

    maxOnes = Math.Max(maxOnes, counter);

    return maxOnes;
  }
}