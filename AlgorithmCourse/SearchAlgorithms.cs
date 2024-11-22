using System.Numerics;

namespace AlgorithmCourse;

public static class SearchAlgorithms
{
    public static bool LinearSearch<T>(T[] haystack, T needle) where T : INumber<T>
    {
        for (var i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle)
            {
                return true;
            }
        }

        return false;
    }

    public static bool BinarySearch<T>(T[] haystack, T needle) where T : INumber<T>
    {
        decimal low = 0;
        decimal high = haystack.Length;

        do
        {
            var middle = (int)Math.Floor(low + (high - low) / 2);
            var value = haystack[middle];

            if (value == needle)
            {
                return true;
            }

            if (value > needle)
            {
                high = middle;
            }
            else
            {
                low = middle + 1;
            }
        }
        while (low < high);

        return false;
    }

    public static int TwoCrystalBalls(bool[] breaks)
    {
        var jumpAmount = Math.Floor(Math.Sqrt(breaks.Length));
        var i = jumpAmount;

        for (; i < breaks.Length; i += jumpAmount)
        {
            if (breaks[(int)i])
            {
                break;
            }
        }

        i -= jumpAmount;

        for(var j = 0; j < jumpAmount && i < breaks.Length; ++j, ++i)
        {
            if (breaks[(int)i])
            {
                return (int)i;
            }
        }

        return -1;
    }
}
