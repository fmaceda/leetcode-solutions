public class Solution
{
  Dictionary<int, int> memo = new Dictionary<int, int>();
  public int Fib(int n)
  {
    if (memo.ContainsKey(n))
    {
      return memo[n];
    }

    if (n <= 1)
    {
      memo.Add(n, n);
      return memo[n];
    }

    memo.Add(n, Fib(n - 1) + Fib(n - 2));

    return memo[n];
  }
}