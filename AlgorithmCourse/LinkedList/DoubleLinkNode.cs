namespace AlgorithmCourse.LinkedList;

public class DoubleLinkNode<T>(
    T value,
    DoubleLinkNode<T>? next,
    DoubleLinkNode<T>? previous)
{
    public T Value { get; set; } = value;
    public DoubleLinkNode<T>? Next { get; set; } = next;
    public DoubleLinkNode<T>? Previous { get; set; } = previous;
}