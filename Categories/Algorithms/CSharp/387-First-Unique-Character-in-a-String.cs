public class Solution
{
  public int FirstUniqChar(string s)
  {
    var mapping = new Dictionary<char, int>();

    foreach (char c in s)
    {
      if (!mapping.ContainsKey(c))
      {
        mapping.Add(c, 0);
      }
      mapping[c]++;
    }

    for (int idx = 0; idx < s.Length; idx++)
    {
      if (mapping[s[idx]] == 1)
      {
        return idx;
      }
    }

    return -1;
  }
}