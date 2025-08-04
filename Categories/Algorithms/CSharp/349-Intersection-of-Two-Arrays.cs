public class Solution
{
  public int[] Intersection(int[] nums1, int[] nums2)
  {
    var solution = new List<int>();
    var mapping = new HashSet<int>();

    foreach (var num in nums1)
    {
      if (!mapping.Contains(num))
      {
        mapping.Add(num);
      }
    }

    foreach (var num in nums2)
    {
      if (mapping.Contains(num))
      {
        solution.Add(num);
        mapping.Remove(num);
      }
    }

    return solution.ToArray();
  }
}