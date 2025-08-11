public class MinStack
{
  List<(int val, int minVal)> myStack;

  public MinStack()
  {
    myStack = new List<(int val, int minVal)>();
  }

  public void Push(int val)
  {
    int minValue = val;

    if (myStack.Count > 0)
    {
      minValue = Math.Min(minValue, myStack[myStack.Count - 1].minVal);
    }
    myStack.Add((val, minValue));
  }

  public void Pop()
  {
    myStack.RemoveAt(myStack.Count - 1);
  }

  public int Top()
  {
    return myStack[myStack.Count - 1].val;
  }

  public int GetMin()
  {
    return myStack[myStack.Count - 1].minVal;
  }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */