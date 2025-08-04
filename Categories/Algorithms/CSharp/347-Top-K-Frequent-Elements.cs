public class Solution
{
  public int[] TopKFrequent(int[] nums, int k)
  {
    var mapping = new Dictionary<int, int>();
    var topElements = new PriorityQueue<int, int>();
    var solution = new List<int>();

    foreach (int num in nums)
    {
      if (!mapping.ContainsKey(num))
      {
        mapping.Add(num, 0);
      }
      mapping[num]++;
    }

    foreach (int key in mapping.Keys)
    {
      topElements.Enqueue(key, -mapping[key]);
    }

    while (k > 0 && topElements.Count > 0)
    {
      solution.Add(topElements.Dequeue());
      k--;
    }

    return solution.ToArray();
  }
}