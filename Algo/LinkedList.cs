namespace Algo;

public class LinkedList<T>
{
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
}
