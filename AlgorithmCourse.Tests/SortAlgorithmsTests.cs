using FluentAssertions;

namespace AlgorithmCourse.Tests;

public class SortAlgorithmsTests
{
    [Fact]
    public void Bubble_sort_should_return_sorted_array()
    {
        var (unsorted, sorted) = CreateUnsortedArray();

        var actual = SortAlgorithms.BubbleSort(unsorted);

        actual.Should().BeEquivalentTo(sorted);
    }

    private static (int[] unsorted, int[] sorted) CreateUnsortedArray()
    {
        var random = new Random();
        var unsorted = Enumerable.Repeat(random.Next(), 10000).ToArray();
        var sorted = unsorted.OrderBy(x => x).ToArray();

        return (unsorted, sorted);
    }
}