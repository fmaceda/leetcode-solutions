public class MyHashMap
{
  int[] table;
  public MyHashMap()
  {
    table = Enumerable.Repeat(-1, 1000001).ToArray();
  }

  public void Put(int key, int value)
  {
    table[key] = value;
  }

  public int Get(int key)
  {
    return table[key];
  }

  public void Remove(int key)
  {
    table[key] = -1;
  }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */