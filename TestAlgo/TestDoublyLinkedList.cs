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
        Assert.Equal(3, list.ItemAt(0).Value);
        Assert.Equal(2, list.ItemAt(1).Value);
        Assert.Equal(1, list.ItemAt(2).Value);
    }

    [Fact]
    public void TestAppend()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        Assert.Equal(3, list.Length);
        Assert.Equal(1, list.ItemAt(0).Value);
        Assert.Equal(2, list.ItemAt(1).Value);
        Assert.Equal(3, list.ItemAt(2).Value);
    }
    
    [Fact]
    public void TestItemAt()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        Assert.Equal(3, list.Length);
        Assert.Equal(1, list.ItemAt(0).Value);
        Assert.Equal(2, list.ItemAt(1).Value);
        Assert.Equal(3, list.ItemAt(2).Value);
    }
    
    [Fact]
    public void TestItemAtException()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        Assert.Equal(3, list.Length);
        Assert.Throws<IndexOutOfRangeException>(() => list.ItemAt(3));
    }
    
    [Fact]
    public void TestNegativeItemAtException()
    {
        DoublyLinkedList<int> list = new();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        Assert.Equal(3, list.Length);
        Assert.Throws<IndexOutOfRangeException>(() => list.ItemAt(-1));
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
        Assert.Equal(5, list.ItemAt(0).Value);
        Assert.Equal(1, list.ItemAt(1).Value);
        Assert.Equal(4, list.ItemAt(2).Value);
        Assert.Equal(2, list.ItemAt(3).Value);
        Assert.Equal(3, list.ItemAt(4).Value);
        Assert.Equal(6, list.ItemAt(5).Value);
    }
}