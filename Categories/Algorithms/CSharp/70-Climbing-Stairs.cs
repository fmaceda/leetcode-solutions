public class Solution
{
  Dictionary<int, int> memo = new Dictionary<int, int>();

  public int ClimbStairs(int n)
  {
    if (memo.ContainsKey(n))
    {
      return memo[n];
    }

    if (n <= 0)
    {
      return n == 0 ? 1 : 0;
    }

    memo[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);

    return memo[n];
  }
}