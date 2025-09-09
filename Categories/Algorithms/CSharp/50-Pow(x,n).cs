public class Solution
{
  public double MyPow(double x, int n)
  {
    long exp = n;

    if (n < 0)
    {
      return 1.0 / PosPow(x, (int)-exp);
    }

    return PosPow(x, (int)exp);
  }

  public double PosPow(double x, int n)
  {
    if (n == 0)
    {
      return 1.0;
    }

    var half = PosPow(x, n / 2);

    return n % 2 == 0 ? half * half : x * half * half;
  }
}