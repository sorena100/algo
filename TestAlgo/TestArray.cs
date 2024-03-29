namespace TestAlgo;

public class TestArray
{
    [Theory]
    [InlineData(0, 2)]
    [InlineData(1, null)]
    [InlineData(2, 3)]
    [InlineData(-1, 1)]
    public void TestBinarySearch(int value, int? expected)
    {
        int[] array = [-3, -1, 0, 2, 3, 4, 5];
        int? actual = Algo.Array.BinarySearch(array, value);
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(-3.4, 0)]
    [InlineData(-2.5, null)]
    [InlineData(-1.5, 1)]
    [InlineData(-0.5, 2)]
    [InlineData(0.5, null)]
    [InlineData(1.5, 3)]
    [InlineData(2.5, 4)]
    [InlineData(3.5, 5)]
    public void TestBinarySearchDouble(double value, int? expected)
    {
        double[] array = [-3.4, -1.5, -0.5, 1.5, 2.5, 3.5];
        int? actual = Algo.Array.BinarySearch(array, value);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void TestBubbleSort()
    {
        int[] array = [3, 1, 2, 5, 4];
        int[] expected = [1, 2, 3, 4, 5];
        int[] actual = Algo.Array.BubbleSort(array);
        Assert.Equal(expected, actual);
    }
}