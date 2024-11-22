namespace AlgorithmCourse.LinkedList;

public class Node<T>(
    T value,
    Node<T>? next,
    Node<T>? previous)
{
    public T Value { get; set; } = value;
    public Node<T>? Next { get; set; } = next;
    public Node<T>? Previous { get; set; } = previous;
}