public class Solution
{
  public bool CheckIfExist(int[] arr)
  {
    var numdoubles = new HashSet<int>();
    
    foreach (int num in arr)
    {
      if(numdoubles.Contains(2 * num) || (num % 2 == 0 && numdoubles.Contains(num / 2)))
      {
        return true;
      }
      
      numdoubles.Add(num);
    }
    
    return false;
  }
}