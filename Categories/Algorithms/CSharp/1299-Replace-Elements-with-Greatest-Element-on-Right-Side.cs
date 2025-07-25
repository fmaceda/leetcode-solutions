public class Solution
{
  public int[] ReplaceElements(int[] arr)
  {
    int highValue = 0;
    int highValueIdx = -1;

    for (int idx = 0; idx < arr.Length; idx++)
    {
      if (idx == highValueIdx)
      {
        highValueIdx = -1;
        highValue = 0;
      }
      
      if (highValueIdx == -1)
      {
        for (int idx2 = idx + 1; idx2 < arr.Length; idx2++)
        {
          if (arr[idx2] > highValue)
          {
            highValue = arr[idx2];
            highValueIdx = idx2;
          }
        }
      }
      
      arr[idx] = highValue;
    }
    
    if (arr.Length > 0)
    {
      arr[^1] = -1;
    }
    
    return arr;
  }
}