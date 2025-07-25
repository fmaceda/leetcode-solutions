public class Solution
{
  public int FindNumbers(int[] nums)
  {
    var counter = 0;

    foreach (int num in nums)
    {
      if (num.ToString().Length % 2 == 0)
      {
        counter++;
      }
    }

    return counter;
  }
}