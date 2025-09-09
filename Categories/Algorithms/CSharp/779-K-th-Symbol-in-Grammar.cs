public class Solution
{
  public int KthGrammar(int n, int k)
  {
    if (n == 1 || k == 1)
    {
      return 0;
    }

    var maxLength = (int)Math.Pow(2, n - 1);
    var halfLength = maxLength / 2;

    if (k <= halfLength)
    {
      return KthGrammar(n - 1, k);
    }

    return 1 - KthGrammar(n - 1, k - halfLength);
  }
}