public class Solution
{
  public bool IsValid(string s)
  {
    var chars = new Stack<char>();

    foreach (char c in s)
    {
      if (chars.Count > 0)
      {
        var currChar = chars.Peek();

        if (
            (currChar == '{' && c == '}') ||
            (currChar == '[' && c == ']') ||
            (currChar == '(' && c == ')')
        )
        {
          chars.Pop();
        }
        else
        {
          chars.Push(c);
        }
      }
      else
      {
        chars.Push(c);
      }
    }

    return chars.Count == 0;
  }
}