namespace MyStack.Stack;

public class MyStack<T>
{
    private List<T> _items;

    public MyStack()
    {
        _items = new List<T>();
    }

    public void Push(T item)
    {
        _items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");
        
        var itemToRemove = _items[_items.Count - 1];
        _items.RemoveAt(_items.Count - 1);
        return itemToRemove;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return _items[_items.Count - 1];
    }

    public bool IsEmpty()
    {
        return _items.Count == 0;
    }

    public int Count
    {
        get { return _items.Count; }
    }
}