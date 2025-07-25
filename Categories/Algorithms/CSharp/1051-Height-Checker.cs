public class Solution
{
  public int HeightChecker(int[] heights)
  {
    // Count frequencies
    int[] sums = new int[101];
    foreach (int height in heights)
      sums[height]++;
    // Convert to prefix sums
    for (int i = 1; i < sums.Length; i++)
      sums[i] = sums[i - 1] + sums[i];

    // Count all out-of-place ones
    int result = 0;
    for (int i = 0; i < heights.Length; i++)
    {
      // Check it the index is not allowed
      if (i < sums[heights[i] - 1] || i >= sums[heights[i]]) result++;
    }

    return result;
  }
}