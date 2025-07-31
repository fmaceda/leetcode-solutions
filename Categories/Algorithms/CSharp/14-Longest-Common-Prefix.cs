public class Solution
{
  public string LongestCommonPrefix(string[] strs)
  {
    StringBuilder sb = new StringBuilder("");

    var firstStr = strs[0];

    for (int idx = 0; idx < firstStr.Length; idx++)
    {
      var currChar = firstStr[idx];
      var addChar = true;

      for (int strIdx = 1; strIdx < strs.Length; strIdx++)
      {
        if (strs[strIdx].Length <= idx)
        {
          addChar = false;
        }

        if (strs[strIdx].Length > idx && strs[strIdx][idx] != currChar)
        {
          addChar = false;
        }
      }

      if (addChar)
      {
        sb.Append(currChar);
      }
      else
      {
        break;
      }
    }

    return sb.ToString();
  }
}