public class Solution
{
  public char NextGreatestLetter(char[] letters, char target)
  {
    var left = 0;
    var right = letters.Length - 1;

    while (left < right)
    {
      var mid = (left + right) / 2;

      if (letters[mid] > target)
      {
        right = mid;
      }
      else if (letters[mid] <= target)
      {
        left = mid + 1;
      }
    }

    if (letters[left] <= target)
    {
      return letters[0];
    }

    return letters[left];
  }
}