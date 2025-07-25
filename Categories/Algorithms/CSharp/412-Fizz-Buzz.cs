public class Solution
{
  public IList<string> FizzBuzz(int n)
  {
    var fizzBuzz = new List<string>();

    for (int idx = 1; idx <= n; idx++)
    {
      if (idx % 15 == 0)
      {
        fizzBuzz.Add("FizzBuzz");
      }
      else if (idx % 3 == 0)
      {
        fizzBuzz.Add("Fizz");
      }
      else if (idx % 5 == 0)
      {
        fizzBuzz.Add("Buzz");
      }
      else
      {
        fizzBuzz.Add(idx.ToString());
      }
    }

    return fizzBuzz;
  }
}