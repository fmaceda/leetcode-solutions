public class RandomizedSet
{
  List<int> uniqueValues;
  Dictionary<int, int> mapping;
  Random random;

  public RandomizedSet()
  {
    uniqueValues = new List<int>();
    mapping = new Dictionary<int, int>();
    random = new Random();
  }

  public bool Insert(int val)
  {
    if (!mapping.ContainsKey(val))
    {
      mapping.Add(val, uniqueValues.Count);
      uniqueValues.Add(val);
      return true;
    }

    return false;
  }

  public bool Remove(int val)
  {
    if (mapping.ContainsKey(val))
    {
      var currItemIdx = mapping[val];
      var lastItemIdx = uniqueValues.Count - 1;

      uniqueValues[currItemIdx] = uniqueValues[lastItemIdx];
      mapping[uniqueValues[lastItemIdx]] = mapping[val];

      uniqueValues.RemoveAt(uniqueValues.Count - 1);
      mapping.Remove(val);
      return true;
    }

    return false;
  }

  public int GetRandom()
  {
    int randomIdx = random.Next(0, uniqueValues.Count);

    return uniqueValues[randomIdx];
  }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */