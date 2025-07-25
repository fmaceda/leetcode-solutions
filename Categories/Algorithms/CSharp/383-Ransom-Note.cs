public class Solution
{
  public bool CanConstruct(string ransomNote, string magazine)
  {
    var magazineChars = new Dictionary<char, int>();

    foreach (var ch in magazine)
    {
      if (!magazineChars.ContainsKey(ch))
      {
        magazineChars[ch] = 0;
      }
      magazineChars[ch]++;
    }

    foreach (var ch in ransomNote)
    {
      if (!magazineChars.ContainsKey(ch) || magazineChars[ch] <= 0)
      {
        return false;
      }
      magazineChars[ch]--;
    }

    return true;
  }
}