using Algo;

namespace TestAlgo;

public class TestDoublyLinkedList
{
    [Fact]
    public void TestPush()
    {
        DoublyLinkedList<int> list = new();
        list.Push(1);
        list.Push(2);
        list.Push(3);
        Assert.Equal(3, list.Length);
        Assert.Equal(3, list.ValueAt(0));
        Assert.Equal(2, list.ValueAt(1));
        Assert.Equal(1, list.ValueAt(2));
    }

    [Fact]
    public void TestAppend()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        Assert.Equal(3, list.Length);
        Assert.Equal(1, list.ValueAt(0));
        Assert.Equal(2, list.ValueAt(1));
        Assert.Equal(3, list.ValueAt(2));
    }
    
    [Fact]
    public void TestValueAt()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        Assert.Equal(3, list.Length);
        Assert.Equal(1, list.ValueAt(0));
        Assert.Equal(2, list.ValueAt(1));
        Assert.Equal(3, list.ValueAt(2));
    }
    
    [Fact]
    public void TestValueAtException()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        Assert.Equal(3, list.Length);
        Assert.Throws<IndexOutOfRangeException>(() => list.ValueAt(3));
    }
    
    [Fact]
    public void TestNegativeValueAt()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        Assert.Equal(3, list.Length);
        Assert.Equal(3, list.ValueAt(-1));
    }

    [Fact]
    public void TestInsertAt()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
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