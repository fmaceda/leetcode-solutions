public class Solution
{
  public int MaximumWealth(int[][] accounts)
  {
    int maxWealth = 0;

    for (int custIdx = 0; custIdx < accounts.Length; custIdx++)
    {
      int custWealth = 0;

      for (int bankIdx = 0; bankIdx < accounts[custIdx].Length; bankIdx++)
      {
        custWealth += accounts[custIdx][bankIdx];
      }

      maxWealth = Math.Max(maxWealth, custWealth);
    }

    return maxWealth;
  }
}