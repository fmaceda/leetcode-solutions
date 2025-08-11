public class Solution
{
  public int[] DailyTemperatures(int[] temperatures)
  {
    var indexes = new Stack<int>();
    var daysToWait = Enumerable.Repeat(0, temperatures.Length).ToArray();

    for (int idx = 0; idx < temperatures.Length; idx++)
    {
      while (indexes.Count > 0)
      {
        var dayIdx = indexes.Peek();

        if (temperatures[idx] > temperatures[dayIdx])
        {
          daysToWait[dayIdx] = idx - indexes.Pop();
        }
        else
        {
          break;
        }
      }

      indexes.Push(idx);
    }

    return daysToWait;
  }
}