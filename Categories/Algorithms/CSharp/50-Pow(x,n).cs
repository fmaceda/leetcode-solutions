public class Solution
{
  public double MyPow(double x, int n)
  {
    long exp = Math.Abs((long)n);
    double result = 1.0;

    while (exp > 0)
    {
      if (exp % 2 == 0)
      {
        x *= x;
        exp /= 2;
      }
      else
      {
        result *= x;
        exp--;
      }
    }

    return n > 0 ? result : 1.0 / result;
  }
}