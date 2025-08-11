public class Solution
{
  public string DecodeString(string s)
  {
    var letters = new Stack<char>();
    var decoded = new List<char>();

    for (int idx = 0; idx < s.Length; idx++)
    {
      letters.Push(s[idx]);

      if (s[idx] == ']')
      {
        letters.Pop();
        var wordChars = new List<char>();
        var timesChars = new List<char>();

        while (letters.Count > 0 && letters.Peek() != '[')
        {
          wordChars.Add(letters.Pop());
        }

        letters.Pop();

        while (letters.Count > 0 && letters.Peek() >= '0' && letters.Peek() <= '9')
        {
          timesChars.Add(letters.Pop());
        }

        timesChars.Reverse();

        var word = string.Join("", wordChars);
        var times = int.Parse(string.Join("", timesChars));

        while (times > 0)
        {
          for (int wordIdx = wordChars.Count - 1; wordIdx >= 0; wordIdx--)
          {
            letters.Push(wordChars[wordIdx]);
          }
          times--;
        }

      }
    }

    while (letters.Count > 0)
    {
      decoded.Add(letters.Pop());
    }

    decoded.Reverse();

    return string.Join("", decoded);
  }
}