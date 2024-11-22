using System.Numerics;

namespace AlgorithmCourse;

public static class SortAlgorithms
{
    public static T[] BubbleSort<T>(T[] input)  where T : INumber<T>
    {
        for(var i = 0; i < input.Length; i++)
        {
            for(var j = 0; j < input.Length - 1 - i; j++)
            {
                if (input[j] > input[j+1])
                {
                    (input[j], input[j+1]) = (input[j+1], input[j]);
                }
            }
        }

        return input;
    }
}
