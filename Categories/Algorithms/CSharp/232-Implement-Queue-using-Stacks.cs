public class MyQueue
{
  private Stack<int> firstTail;
  private Stack<int> firstHead;

  public MyQueue()
  {
    firstHead = new();
    firstTail = new();
  }

  public void Push(int x)
  {
    OrderLIFO();

    firstTail.Push(x);
  }

  public int Pop()
  {
    OrderFIFO();

    return firstHead.Pop();
  }

  public int Peek()
  {
    OrderFIFO();

    return firstHead.Peek();
  }

  public bool Empty()
  {
    OrderLIFO();

    return firstTail.Count == 0;
  }

  private void OrderFIFO()
  {
    while (firstTail.Count > 0)
    {
      var item = firstTail.Pop();
      firstHead.Push(item);
    }
  }

  private void OrderLIFO()
  {
    while (firstHead.Count > 0)
    {
      var item = firstHead.Pop();
      firstTail.Push(item);
    }
  }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */