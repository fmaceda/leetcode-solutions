public class MyHashSet
{
  bool[] table;

  public MyHashSet()
  {
    table = new bool[1000001];
  }

  public void Add(int key)
  {
    table[key] = true;
  }

  public void Remove(int key)
  {
    table[key] = false;
  }

  public bool Contains(int key)
  {
    return table[key];
  }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */