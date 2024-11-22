namespace AlgorithmCourse.LinkedList;

public interface ILinkedList<T>
{
    int Length { get; }
    void InsertAt(T value, int index);
    void Remove(T value);
    void RemoveAt(int index);
    T Get(int index);
    void Append(T value);
    void Prepend(T value);
}
