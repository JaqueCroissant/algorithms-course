namespace AlgorithmCourse.Queue;

public class MyQueue<T> where T : struct
{
    public int Length { get; private set; }

    public MyQueue()
    {
        Length = 0;
        _head = null;
        _tail = null;
    }

    private QueueNode<T>? _head;
    private QueueNode<T>? _tail;

    public void Enqueue(T value)
    {
        if(_tail == null)
        {
            _tail = new QueueNode<T>(value, null);
            _head = _tail;
            
        }
        else
        {
            _tail.Next = new QueueNode<T>(value, null);
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
