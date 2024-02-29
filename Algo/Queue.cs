namespace Algo;

public class Queue<T>
{
    public Queue()
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
    }


    #region methodes

    public T Pop()
    {
        Node<T> node = _head ?? throw new NullReferenceException();
        _head = _head.Next;
        node.Next = null;
        Length -= 1;
        return node.Value;
    }

    public void Insert(T value)
    {
        Node<T> newNode = new(value);
        _head ??= newNode;
        if (_tail != null) _tail.Next = newNode;
        _tail = newNode;
        Length += 1;
    }

    #endregion
}
