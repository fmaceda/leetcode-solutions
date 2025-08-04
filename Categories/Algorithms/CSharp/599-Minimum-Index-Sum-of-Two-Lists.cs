public class Solution
{
  public string[] FindRestaurant(string[] list1, string[] list2)
  {
    var commonStringsIdxsSum = new PriorityQueue<string, int>();
    var mapping = new Dictionary<string, int>();

    for (int idx = 0; idx < list1.Length; idx++)
    {
      mapping.Add(list1[idx], idx);
    }

    for (int idx = 0; idx < list2.Length; idx++)
    {
      if (mapping.ContainsKey(list2[idx]))
      {
        commonStringsIdxsSum.Enqueue(list2[idx], mapping[list2[idx]] + idx);
      }
    }

    var commonStrings = new List<string>();
    commonStringsIdxsSum.TryDequeue(out string firstItem, out int minDiff);
    commonStrings.Add(firstItem);

    while (commonStringsIdxsSum.Count > 0)
    {
      commonStringsIdxsSum.TryDequeue(out string item, out int diff);

      if (diff <= minDiff)
      {
        commonStrings.Add(item);
      }
      else
      {
        break;
      }
    }

    return commonStrings.ToArray();
  }
}