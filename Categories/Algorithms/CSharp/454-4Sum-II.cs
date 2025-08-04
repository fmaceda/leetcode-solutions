public class Solution
{
  public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
  {
    var mapping = new Dictionary<int, int>();
    var count = 0;

    foreach (int num1 in nums1)
    {
      foreach (int num2 in nums2)
      {
        if (!mapping.ContainsKey(num1 + num2))
        {
          mapping.Add(num1 + num2, 0);
        }
        mapping[num1 + num2]++;
      }
    }

    foreach (int num3 in nums3)
    {
      foreach (int num4 in nums4)
      {
        if (mapping.ContainsKey(-(num3 + num4)))
        {
          count += mapping[-(num3 + num4)];
        }
      }
    }

    return count;
  }
}