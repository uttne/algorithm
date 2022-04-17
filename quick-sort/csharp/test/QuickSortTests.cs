using Xunit;
using Xunit.Abstractions;
using System.Diagnostics;
using System;
using System.Linq;

namespace Algorithm.Tests;

public class QuickSortTests
{
    private readonly ITestOutputHelper _output;

    public QuickSortTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Test()
    {
        var list = new int[] { 99, 77, 52, 68, 6, 68, 45, 84, 15, 1 };

        var expected = new int[] { 1, 6, 15, 45, 52, 68, 68, 77, 84, 99 };

        var alg = new QuickSort();
        alg.Sort(list);

        Assert.Equal(expected, list);
    }


    [Fact]
    public void SpeedTest()
    {
        var random = new Random(0);

        var list = Enumerable.Range(0, 50000).Select(_ => random.Next()).ToArray();

        var expected = list.ToArray();

        var sw = new Stopwatch();

        var alg = new QuickSort();


        sw.Restart();
        Array.Sort(expected);
        sw.Stop();
        var runtimeSortTime = sw.Elapsed.TotalMilliseconds;

        sw.Restart();
        alg.Sort(list);
        sw.Stop();
        var mySortTime = sw.Elapsed.TotalMilliseconds;


        Assert.Equal(expected, list);

        _output.WriteLine($"Array.Sort              : {runtimeSortTime:0.000} [msec]");
        _output.WriteLine($"Quick Sort              : {mySortTime:0.000} [msec]");
        _output.WriteLine($"Quick Sort / Array.Sort : {(mySortTime * 100d / runtimeSortTime):0.000} [%]");
    }
}