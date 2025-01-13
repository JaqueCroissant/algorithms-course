namespace AlgorithmCourse;

public class SingleLinkNode<T>(T value, SingleLinkNode<T>? next)
{
    public T Value { get; } = value;

    public SingleLinkNode<T>? Next { get; set; } = next;
}
