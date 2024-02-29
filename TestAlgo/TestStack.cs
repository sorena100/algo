using Stack= Algo.Stack<int>;

namespace TestAlgo;

public class TestStack
{
    [Fact]
    public void TestInsertAndPop()
    {
        Stack stack = new();
        stack.Insert(1);
        stack.Insert(2);
        stack.Insert(3);
        Assert.Equal(3, stack.Length);
        Assert.Equal(3, stack.Pop());
        Assert.Equal(2, stack.Pop());
        Assert.Equal(1, stack.Pop());
        Assert.Equal(0, stack.Length);
        Assert.Throws<NullReferenceException>(() => stack.Pop());
    }
}