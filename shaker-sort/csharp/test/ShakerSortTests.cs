using Xunit;

namespace Algorithm.Tests;

public class ShakerSortTests
{
    [Fact]
    public void Test()
    {
        var list = new int[] { 99, 77, 52, 68, 6, 68, 45, 84, 15, 1 };

        var expected = new int[] { 1, 6, 15, 45, 52, 68, 68, 77, 84, 99 };

        var alg = new ShakerSort();
        alg.Sort(list);

        Assert.Equal(expected, list);
    }
}