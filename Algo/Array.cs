namespace Algo;

public class Array
{
    public static int? BinarySearch<T>(T[] array, T value) where T : IComparable<T>
    {
        int middleIndex = array.Length / 2;
        T middleValue = array[middleIndex];
        int comparision = value.CompareTo(middleValue);
        
        if (comparision == 0)
        {
            return middleIndex;
        }
        if (middleIndex == 0)
        {
            return null;
        }

        if (comparision < 0)
        {
            return BinarySearch(array[..middleIndex], value);
        }

        return middleIndex + 1 + BinarySearch(array[(middleIndex+1)..], value);
    }

    public static T[] BubbleSort<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
        return array;
    }
}