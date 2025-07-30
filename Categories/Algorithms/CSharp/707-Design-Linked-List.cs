public class Node(int val)
{
  public int val = val;
  public Node next = null;
}

public class MyLinkedList
{
  private Node head;

  public MyLinkedList()
  {
    head = null;
  }

  public void PrintList()
  {
    Node curr = head;

    while (curr != null)
    {
      Console.Write($"{curr.val} -> ");
      curr = curr.next;
    }
    Console.WriteLine();
  }

  public int Get(int index)
  {
    Node curr = head;

    if (curr == null)
    {
      return -1;
    }

    while (curr != null && index > 0)
    {
      curr = curr.next;
      index--;
    }

    if (curr != null)
    {
      return curr.val;
    }

    return -1;
  }

  public void AddAtHead(int val)
  {
    Node curr = head;

    if (curr == null)
    {
      curr = new Node(val);
      head = curr;
      return;
    }

    var newNode = new Node(val);
    newNode.next = head;
    head = newNode;
  }

  public void AddAtTail(int val)
  {
    Node curr = head;

    if (curr == null)
    {
      AddAtHead(val);
      return;
    }

    while (curr.next != null)
    {
      curr = curr.next;
    }

    curr.next = new Node(val);
  }

  public void AddAtIndex(int index, int val)
  {
    Node curr = head;

    if (index == 0)
    {
      AddAtHead(val);
      return;
    }

    if (curr == null)
    {
      return;
    }

    // Reduce the index by 1 for getting the prev node in the list.
    index--;

    while (curr.next != null && index > 0)
    {
      curr = curr.next;
      index--;
    }

    if (curr != null)
    {
      var newNode = new Node(val);
      newNode.next = curr.next;
      curr.next = newNode;
    }
  }

  public void DeleteAtIndex(int index)
  {
    Node curr = head;

    if (curr == null)
    {
      return;
    }

    if (index == 0)
    {
      head = curr.next;
    }

    // Reduce the index by 1 for getting the prev node in the list.
    index--;

    while (curr.next != null && index > 0)
    {
      curr = curr.next;
      index--;
    }

    if (curr != null && curr.next != null)
    {
      curr.next = curr.next.next;
    }
  }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */