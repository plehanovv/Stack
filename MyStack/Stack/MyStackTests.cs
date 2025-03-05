using Xunit;

namespace MyStack.Stack;

public class MyStackTests
{
    [Fact]
    public void PushTest()
    {
        var stack = new MyStack<int>();
        stack.Push(10);
        Assert.Equal(10, stack.Peek());
        Assert.Equal(1, stack.Count);
    }

    [Fact]
    public void PopTest()
    {
        var stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(20);
        
        var popped = stack.Pop();
        
        Assert.Equal(20, popped);
        Assert.Equal(1, stack.Count);
    }

    [Fact]
    public void PopThrowsExceptionOnEmptyStack()
    {
        var stack = new MyStack<int>();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }
}