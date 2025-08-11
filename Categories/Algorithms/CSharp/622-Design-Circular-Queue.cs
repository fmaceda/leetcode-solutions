public class MyCircularQueue
{
  int[] queue;
  int headPointer;
  int tailPointer;
  int count;
  int maxSize;

  public MyCircularQueue(int k)
  {
    queue = new int[k];
    headPointer = 0;
    tailPointer = 0;
    count = 0;
    maxSize = k;
  }

  public bool EnQueue(int value)
  {
    if (IsFull())
    {
      return false;
    }

    queue[tailPointer] = value;
    tailPointer = (tailPointer + 1) % maxSize;
    count++;
    return true;
  }

  public bool DeQueue()
  {
    if (IsEmpty())
    {
      return false;
    }

    headPointer = (headPointer + 1) % maxSize;
    count--;

    return true;
  }

  public int Front()
  {
    if (IsEmpty())
    {
      return -1;
    }

    return queue[headPointer];
  }

  public int Rear()
  {
    if (IsEmpty())
    {
      return -1;
    }

    return queue[(maxSize - 1 + tailPointer) % maxSize];
  }

  public bool IsEmpty()
  {
    return count == 0;
  }

  public bool IsFull()
  {
    return count == maxSize;
  }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */