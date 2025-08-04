public class Solution
{
  public int[] Intersect(int[] nums1, int[] nums2)
  {
    var mapping = new Dictionary<int, int>();
    var solution = new List<int>();

    foreach (int num in nums1)
    {
      if (!mapping.ContainsKey(num))
      {
        mapping.Add(num, 0);
      }
      mapping[num]++;
    }

    foreach (int num in nums2)
    {
      if (mapping.ContainsKey(num) && mapping[num] > 0)
      {
        mapping[num]--;
        solution.Add(num);
      }
    }

    return solution.ToArray();
  }
}