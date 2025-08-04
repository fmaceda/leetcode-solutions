public class Solution
{
  public bool IsIsomorphic(string s, string t)
  {
    var mapping = new Dictionary<char, char>();

    for (int idx = 0; idx < s.Length; idx++)
    {
      if (mapping.ContainsKey(s[idx]))
      {
        if (!mapping[s[idx]].Equals(t[idx]))
        {
          return false;
        }
      }
      else
      {
        if (mapping.ContainsValue(t[idx]))
        {
          return false;
        }
        mapping.Add(s[idx], t[idx]);
      }
    }

    return true;
  }
}