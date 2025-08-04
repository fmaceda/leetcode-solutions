public class Solution
{
  public int LengthOfLongestSubstring(string s)
  {
    if (s.Length <= 1)
    {
      return s.Length;
    }

    var mapping = new Dictionary<char, bool>();
    var lowIdx = 0;
    var highIdx = 0;
    var maxLength = 0;

    while (lowIdx < s.Length && highIdx < s.Length)
    {
      var curr = s[highIdx];
      var oldest = s[lowIdx];

      if (mapping.ContainsKey(curr))
      {
        mapping.Remove(oldest);
        lowIdx++;
      }
      else
      {
        maxLength = Math.Max(maxLength, highIdx - lowIdx + 1);
        mapping.Add(curr, true);
        highIdx++;
      }
    }

    return maxLength;
  }
}