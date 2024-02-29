using Queue = Algo.Queue<int>; 

namespace TestAlgo;

public class TestQueue
{
    [Fact]
    public void TestInsertAndPop()
    {
        Queue queue = new();
        queue.Insert(1);
        queue.Insert(2);
        queue.Insert(3);
        Assert.Equal(3, queue.Length);
        Assert.Equal(1, queue.Pop());
        Assert.Equal(2, queue.Pop());
        Assert.Equal(3, queue.Pop());
        Assert.Equal(0, queue.Length);
        Assert.Throws<NullReferenceException>(() => queue.Pop());
    }
}