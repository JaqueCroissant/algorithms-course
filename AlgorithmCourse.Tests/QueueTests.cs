using AlgorithmCourse.Queue;
using FluentAssertions;

namespace AlgorithmCourse.Tests;

public class QueueTests
{
    [Fact]
    public void Queue_should_have_zero_length_when_initialized()
    {
        var sut = new MyQueue<int>();

        sut.Length.Should().Be(0);
    }

    [Fact]
    public void Queue_should_have_same_length_as_input_after_enqueueing()
    {
        var input = CreateInput();
        var sut = new MyQueue<int>();

        foreach (var item in input)
        {
            sut.Enqueue(item);
        }

        sut.Length.Should().Be(input.Length);
    }

    [Fact]
    public void Queue_should_return_same_order_as_input()
    {
        var input = CreateInput();
        var sut = new MyQueue<int>();

        foreach (var item in input)
        {
            sut.Enqueue(item);
        }

        var result = new List<int>();

        while(sut.Peek() != null)
        {
            var output = sut.Dequeue();
            result.Add((int)output!);
        }

        result.Should().BeEquivalentTo(input);
    }

    private static int[] CreateInput()
    {
        var random = new Random();
        return Enumerable.Repeat(random.Next(), 10000).ToArray();
    }
}