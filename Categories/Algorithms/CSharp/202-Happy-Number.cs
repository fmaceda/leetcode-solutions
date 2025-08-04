public class Solution
{
  public int SumDigitSquares(int n)
  {
    int sum = 0;

    while (n > 0)
    {
      sum += ((n % 10) * (n % 10));
      n /= 10;
    }

    return sum;
  }

  public bool IsHappy(int n)
  {
    var mapping = new HashSet<int>();

    while (!mapping.Contains(n))
    {
      mapping.Add(n);
      n = SumDigitSquares(n);

      if (n == 1)
      {
        return true;
      }
    }

    return false;
  }
}