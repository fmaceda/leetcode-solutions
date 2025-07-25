public class Solution
{
  public void DuplicateZeros(int[] arr)
  {
    var toInsert = new Queue<int>();
    for (int idx = 0; idx < arr.Length; idx++)
    {
      if (toInsert.Count > 0)
      {
        toInsert.Enqueue(arr[idx]);

        if (arr[idx] == 0)
        {
          toInsert.Enqueue(0);
        }

        arr[idx] = toInsert.Dequeue();
      }
      else
      {
        if (arr[idx] == 0)
        {
          toInsert.Enqueue(0);
        }
      }
    }
  }
}