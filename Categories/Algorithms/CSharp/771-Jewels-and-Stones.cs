public class Solution
{
  public int NumJewelsInStones(string jewels, string stones)
  {
    var mapping = new Dictionary<char, bool>();
    int jewelsCount = 0;

    foreach (char c in jewels)
    {
      if (!mapping.ContainsKey(c))
      {
        mapping.Add(c, true);
      }
    }

    foreach (char c in stones)
    {
      if (mapping.ContainsKey(c))
      {
        jewelsCount++;
      }
    }

    return jewelsCount;
  }
}