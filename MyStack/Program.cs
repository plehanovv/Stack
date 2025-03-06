using MyStack;

public class Program
{
    public static void Main(string[] args)
    {
        var myStack = new MyStack<int>();
        var defaultStack = new Stack<int>();

        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        defaultStack.Push(1);
        defaultStack.Push(2);
        defaultStack.Push(3);
        
        Console.WriteLine($"Top element: {myStack.Peek()}");
        Console.WriteLine($"Top element: {defaultStack.Peek()}");

        Console.WriteLine($"Popped element: {myStack.Pop()}");
        Console.WriteLine($"Popped element: {defaultStack.Pop()}");

        Console.WriteLine($"MyStack count: {myStack.Count}");
        Console.WriteLine($"Default stack count: {defaultStack.Count}");

        Console.WriteLine($"Is stack empty? {myStack.IsEmpty()}");
    }
}
