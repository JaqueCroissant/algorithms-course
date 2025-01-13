namespace AlgorithmCourse.Queue;

public class SimpleQueue<T> where T : struct
{
    public int Length { get; private set; } = 0;

    private SingleLinkNode<T>? _head;
    private SingleLinkNode<T>? _tail;

    public void Enqueue(T value)
    {
        if(_tail == null)
        {
            _tail = new SingleLinkNode<T>(value, null);
            _head = _tail;
            
        }
        else
        {
            _tail.Next = new SingleLinkNode<T>(value, null);
            _tail = _tail.Next;
        }

        Length++;
    }

    public T? Dequeue()
    {
        if(_head == null)
        {
            return null;
        }

        Length--;

        var current = _head;
        _head = _head.Next;

        return current?.Value;
    }

    public T? Peek()
    {
        return _head?.Value;
    }
}
