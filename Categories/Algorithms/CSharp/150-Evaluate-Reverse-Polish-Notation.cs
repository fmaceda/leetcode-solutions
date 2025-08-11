public class Solution
{
  public int Operate(Stack<int> items, string operation)
  {
    int total = 0;

    if (items.Count >= 2)
    {
      var second = items.Pop();
      var first = items.Pop();

      switch (operation)
      {
        case "+":
          total = first + second;
          break;
        case "-":
          total = first - second;
          break;
        case "*":
          total = first * second;
          break;
        case "/":
          total = first / second;
          break;
        default:
          break;
      }
    }

    return total;
  }

  public int EvalRPN(string[] tokens)
  {
    var total = 0;

    var items = new Stack<int>();

    foreach (string token in tokens)
    {
      if (Array.IndexOf(["+", "-", "*", "/"], token) >= 0)
      {
        total = Operate(items, token);
        items.Push(total);
      }
      else
      {
        items.Push(int.Parse(token));
      }
    }

    if (items.Count > 0)
    {
      return items.Pop();
    }

    return total;
  }
}