namespace Algo;

public class BinarySearch
{
    public static int? Search<T>(T[] array, T value) where T : IComparable<T>
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
            return Search(array[..middleIndex], value);
        }

        return middleIndex + 1 + Search(array[(middleIndex+1)..], value);
    }
}