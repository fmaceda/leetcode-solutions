public class Solution
{
  public string ReverseWords(string s)
  {
    s = s.Trim();
    string[] words = s
        .Split(' ')
        .Select(w =>
        {
          char[] charArray = w.ToCharArray();
          Array.Reverse(charArray);
          return new string(charArray);
        }).ToArray();

    return string.Join(" ", words);
  }
}