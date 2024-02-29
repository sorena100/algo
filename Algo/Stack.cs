namespace Algo;

public class Stack<T>
{
    public Stack()
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
        public Node<T1>? Previous { get; set; }
    }


    #region methodes

    public T Pop()
    {
        Node<T> node = _tail ?? throw new NullReferenceException();
        _tail = _tail.Previous;
        node.Previous = null;
        Length -= 1;
        return node.Value;
    }

    public void Insert(T value)
    {
        Node<T> newNode = new(value);
        _head ??= newNode;
        if (_tail != null) newNode.Previous = _tail;
        _tail = newNode;
        Length += 1;
    }

    #endregion
}
