public class MyStack
{
  private Queue<int> firstQueue;
  private Queue<int> secondQueue;
  private bool usingFirstQueue;

  public MyStack()
  {
    firstQueue = new();
    secondQueue = new();
    usingFirstQueue = true;
  }

  public void Push(int x)
  {
    if (usingFirstQueue)
    {
      firstQueue.Enqueue(x);
    }
    else
    {
      secondQueue.Enqueue(x);
    }
    MoveBetweenQueues();
  }

  public int Pop()
  {
    int itemToReturn = -1;
    if (usingFirstQueue)
    {
      itemToReturn = firstQueue.Dequeue();
    }
    else
    {
      itemToReturn = secondQueue.Dequeue();
    }

    usingFirstQueue = !usingFirstQueue;
    MoveBetweenQueues();

    return itemToReturn;
  }

  public int Top()
  {
    if (usingFirstQueue)
    {
      return firstQueue.Peek();
    }
    else
    {
      return secondQueue.Peek();
    }
  }

  public bool Empty()
  {
    return firstQueue.Count == 0 && secondQueue.Count == 0;
  }

  private void MoveBetweenQueues()
  {
    if (usingFirstQueue)
    {
      while (firstQueue.Count > 1)
      {
        var item = firstQueue.Dequeue();
        secondQueue.Enqueue(item);
      }
    }
    else
    {
      while (secondQueue.Count > 1)
      {
        var item = secondQueue.Dequeue();
        firstQueue.Enqueue(item);
      }
    }
  }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */