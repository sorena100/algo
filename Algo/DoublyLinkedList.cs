using System.Diagnostics;

namespace Algo;

public abstract class DoublyLinkedList<T>
{
    public DoublyLinkedList()
    {
        Length = 0;
    }

    private Node<T>? _head;
    private Node<T>? _tail;

    public int Length { get; private set; }

    public class Node<T1>
    {
        public Node(T1 value)
        {
            Value = value;
        }

        public T1 Value { get; set; }
        public Node<T1>? Next { get; set; }
        public Node<T1>? Previous { get; set; }
    }


    #region methodes

    public Node<T> ItemAt(int index)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, Length);
        
        Node<T>? node = _head;
        for (int i = 0; i < index; i++)
        {
            if (node == null) throw new NullReferenceException();
            node = node.Next;
        }

        return node ?? throw new NullReferenceException();
    }

    public void InsertAt(int index, T value)
    {
        Node<T> newNode = new(value);
        if (index == 0)
        {
            newNode.Next = _head;
            if (_head != null) _head.Previous = newNode;
            _head = newNode;
            Length += 1;
            return;
        }
        
        Node<T> nodeBefore = ItemAt(index-1);
        newNode.Next = nodeBefore.Next;
        newNode.Previous = nodeBefore;
        if (nodeBefore.Next != null)
        {
            nodeBefore.Next.Previous = newNode;
        }
        nodeBefore.Next = newNode;
    }

    #endregion
}