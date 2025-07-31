public class Solution
{
  public int[] PlusOne(int[] digits)
  {
    int currIdx = digits.Length - 1;

    int remaining = 1;

    while (remaining > 0 && currIdx >= 0)
    {
      (digits[currIdx], remaining) = ((digits[currIdx] + remaining) % 10, (digits[currIdx] + remaining) / 10);
      currIdx--;
    }

    if (remaining != 0)
    {
      var newDigits = new int[digits.Length + 1];
      newDigits[0] = remaining;

      for (int idx = 1; idx < newDigits.Length; idx++)
      {
        newDigits[idx] = digits[idx - 1];
      }

      return newDigits;
    }

    return digits;
  }
}