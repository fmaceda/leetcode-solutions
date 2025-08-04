public class Solution
{
  public bool ContainsDuplicate(int[] nums)
  {
    var values = new HashSet<int>();

    foreach (int num in nums)
    {
      if (values.Contains(num))
      {
        return true;
      }
      values.Add(num);
    }

    return false;
  }
}