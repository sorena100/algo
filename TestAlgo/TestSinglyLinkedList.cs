using Algo;

namespace TestAlgo;

public class TestSinglyLinkedList
{
    [Fact]
    public void TestPush()
    {
        SinglyLinkedList<int> list = new();
        list.Push(1);
        list.Push(2);
        list.Push(3);
        Assert.Equal(3, list.Length);
        Assert.Equal(3, list.ValueAt(0));
        Assert.Equal(2, list.ValueAt(1));
        Assert.Equal(1, list.ValueAt(2));
    }

    [Fact]
    public void TestValueAt()
    {
        SinglyLinkedList<int> list = new();
        list.Push(3);
        list.Push(2);
        list.Push(1);
        Assert.Equal(3, list.Length);
        Assert.Equal(1, list.ValueAt(0));
        Assert.Equal(2, list.ValueAt(1));
        Assert.Equal(3, list.ValueAt(2));
    }
    
    [Fact]
    public void TestValueAtException()
    {
        SinglyLinkedList<int> list = new();
        list.Push(3);
        list.Push(2);
        list.Push(1);
        Assert.Equal(3, list.Length);
        Assert.Throws<IndexOutOfRangeException>(() => list.ValueAt(3));
    }
    
    [Fact]
    public void TestNegativeValueAtException()
    {
        SinglyLinkedList<int> list = new();
        list.Push(3);
        list.Push(2);
        list.Push(1);
        Assert.Equal(3, list.Length);
        Assert.Throws<IndexOutOfRangeException>(() => list.ValueAt(-1));
    }

    [Fact]
    public void TestInsertAt()
    {
        SinglyLinkedList<int> list = new();
        list.Push(3);
        list.Push(2);
        list.Push(1);
        list.InsertAt(1, 4);
        list.InsertAt(0, 5);
        list.InsertAt(5, 6);
        Assert.Equal(6, list.Length);
        Assert.Equal(5, list.ValueAt(0));
        Assert.Equal(1, list.ValueAt(1));
        Assert.Equal(4, list.ValueAt(2));
        Assert.Equal(2, list.ValueAt(3));
        Assert.Equal(3, list.ValueAt(4));
        Assert.Equal(6, list.ValueAt(5));
    }
}