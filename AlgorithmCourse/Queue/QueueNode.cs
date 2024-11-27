namespace AlgorithmCourse.Queue;

public class QueueNode<T>(T value, QueueNode<T>? next)
{
    public T Value { get; } = value;

    public QueueNode<T>? Next { get; set; } = next;
}
