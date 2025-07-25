public class Solution
{
  public int ThirdMax(int[] nums)
  {
    long first = long.MinValue;
    long second = long.MinValue;
    long third = long.MinValue;

    int maximunNumbers = 0;

    foreach (int num in nums)
    {
      bool alreadyInTop = num == first || num == second || num == third;

      if (!alreadyInTop)
      {
        if (num > third && num > second && num > first)
        {
          third = (long)second;
          second = (long)first;
          first = (long)num;
          maximunNumbers++;
        }
        else if (num > third && num > second)
        {
          third = (long)second;
          second = (long)num;
          maximunNumbers++;
        }
        else if (num > third)
        {
          third = (long)num;
          maximunNumbers++;
        }
      }
    }

    if (maximunNumbers >= 3)
    {
      return (int)third;
    }

    return (int)first;
  }
}