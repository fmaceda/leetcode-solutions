public class Solution
{
  public void ReverseString(char[] s)
  {
    int startIdx = 0;
    int endIdx = s.Length - 1;

    while (startIdx < endIdx)
    {
      (s[startIdx], s[endIdx]) = (s[endIdx], s[startIdx]);
      startIdx++;
      endIdx--;
    }
  }
}