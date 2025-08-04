public class Solution
{
  public int SingleNumber(int[] nums)
  {
    var values = new HashSet<int>();

    foreach (int num in nums)
    {
      if (values.Contains(num))
      {
        values.Remove(num);
      }
      else
      {
        values.Add(num);
      }
    }

    var enumerator = values.GetEnumerator();

    if (enumerator.MoveNext())
    {
      return enumerator.Current;
    }

    return -1;
  }
}