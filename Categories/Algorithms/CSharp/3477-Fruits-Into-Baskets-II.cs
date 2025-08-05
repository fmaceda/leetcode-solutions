public class Solution
{
  public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
  {
    var count = 0;

    for (int fruitIdx = 0; fruitIdx < fruits.Length; fruitIdx++)
    {
      for (int basketIdx = 0; basketIdx < baskets.Length; basketIdx++)
      {
        if (baskets[basketIdx] >= fruits[fruitIdx])
        {
          baskets[basketIdx] = 0;
          fruits[fruitIdx] = 0;
          break;
        }
      }
      if (fruits[fruitIdx] > 0)
      {
        count++;
      }
    }

    return count;
  }
}