namespace Algo;

public class DoublyLinkedList<T>
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

    private Node<T> ItemAt(int index)
    {
        if (index < -Length || index >= Length)
        {
            throw new IndexOutOfRangeException();
        }
        
        if (index < 0) index += Length;
        if (index < Length / 2)
        {
            Node<T>? node = _head;
            for (int i = 0; i < index; i++)
            {
                if (node == null) throw new NullReferenceException();
                node = node.Next;
            }

            return node ?? throw new NullReferenceException();
        }
        else
        {
            Node<T>? node = _tail;
            for (int i = Length - 1; i > index; i--)
            {
                if (node == null) throw new NullReferenceException();
                node = node.Previous;
            }

            return node ?? throw new NullReferenceException();
        }
    }
    
    public T ValueAt(int index)
    {
        return ItemAt(index).Value;
    }

    public void Push(T value)
    {
        Node<T> newNode = new(value);
        newNode.Next = _head;
        if (_head != null) _head.Previous = newNode;
        else _tail = newNode;
        _head = newNode;
        Length += 1;
    }

    public void Append(T value)
    {
        Node<T> newNode = new(value);
        newNode.Previous = _tail;
        if (_tail != null) _tail.Next = newNode;
        else _head = newNode;
        _tail = newNode;
        Length += 1;
    }

    private void InsertAfter(Node<T> node, T value)
    {
        Node<T> newNode = new(value);
        newNode.Next = node.Next;
        newNode.Previous = node;
        if (node.Next != null) node.Next.Previous = newNode;
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
        if (index == Length)
        {
            Append(value);
            return;
        }
        InsertAfter(ItemAt(index - 1), value);
    }

    #endregion
}