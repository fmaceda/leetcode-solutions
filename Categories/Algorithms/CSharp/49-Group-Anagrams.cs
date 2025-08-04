public class Solution
{
  public IList<IList<string>> GroupAnagrams(string[] strs)
  {
    var mapping = new Dictionary<string, IList<string>>();

    foreach (string str in strs)
    {
      var strParts = str.ToCharArray();
      Array.Sort(strParts);
      var key = string.Join("", strParts);

      if (!mapping.ContainsKey(key))
      {
        mapping.Add(key, new List<string>());
      }

      mapping[key].Add(str);
    }

    return mapping.Values.ToList();
  }
}