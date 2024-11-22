using FluentAssertions;

namespace AlgorithmCourse.Tests;

public class SearchAlgorithmsTests
{
    [Fact]
    public void Linear_search_should_find_needle_in_haystack()
    {
        var (haystack, needle) = GenerateHaystackAndNeedle();

        var actual = SearchAlgorithms.LinearSearch(haystack, needle);

        actual.Should().BeTrue();
    }

    [Fact]
    public void Binary_search_should_find_needle_in_haystack()
    {
        var (haystack, needle) = GenerateHaystackAndNeedle();

        var actual = SearchAlgorithms.BinarySearch(haystack, needle);

        actual.Should().BeTrue();
    }

    [Fact]
    public void Crystal_balls_search_should_find_last_false_index()
    {
        var (breaks, lastFalseIndex) = GenerateCrystalBallBreaks();

        var actual = SearchAlgorithms.TwoCrystalBalls(breaks);

        actual.Should().Be(lastFalseIndex);
    }

    private static (int[] haystack, int needle) GenerateHaystackAndNeedle()
    {
        var haystack = Enumerable.Range(-50_000, 100_000).ToArray();
        var needle = new Random().Next(-50_000, 50_000);

        return (haystack, needle);
    }

    private static (bool[] breaks, int lastFalseIndex) GenerateCrystalBallBreaks()
    {
        var falseValues = Enumerable.Repeat(false, new Random().Next(10000)).ToList();
        var trueValues = Enumerable.Repeat(true, new Random().Next(10000)).ToList();

        var breaks = falseValues.Concat(trueValues).ToArray();
        var lastFalseIndex = falseValues.Count;

        return (breaks, lastFalseIndex);
    }
}