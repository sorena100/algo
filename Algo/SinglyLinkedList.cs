namespace Algo;

public class SinglyLinkedList<T>
{
    public SinglyLinkedList()
    {
        Length = 0;
    }

    private Node<T>? _head;

    public int Length { get; private set; }

    public class Node<T1>
    {
        public Node(T1 value)
        {
            Value = value;
        }

        public T1 Value { get; set; }
        public Node<T1>? Next { get; set; }
    }


    #region methodes

    private Node<T> ItemAt(int index)
    {
        if (index < 0 || index >= Length)
        {
            throw new IndexOutOfRangeException();
        }
        
        Node<T>? node = _head;
        for (int i = 0; i < index; i++)
        {
            if (node == null) throw new NullReferenceException();
            node = node.Next;
        }

        return node ?? throw new NullReferenceException();
    }
    
    public T ValueAt(int index)
    {
        return ItemAt(index).Value;
    }

    public void Push(T value)
    {
        Node<T> newNode = new(value);
        newNode.Next = _head;
        _head = newNode;
        Length += 1;
    }

    private void InsertAfter(Node<T> node, T value)
    {
        Node<T> newNode = new(value);
        newNode.Next = node.Next;
        node.Next = newNode;
        Length += 1;
    }

    public void InsertAt(int index, T value)
    {
        if (index < 0 || index > Length)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (index == 0)
        {
            Push(value);
            return;
        }
        InsertAfter(ItemAt(index - 1), value);
    }

    #endregion
}
