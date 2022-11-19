using System.Collections.Generic;
using ProjectEulerProblems.Problem_6;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests; 

public class Problem6Tests
{
    public List<long> testset = new List<long>{3,3};

    [Theory]
    [InlineData(2640, 10)]
    [InlineData(25164150, 100)]
    public void Test(long expected, long input) {
        Assert.Equal(expected, Lib.SumSquareDifference(input));
    }

    [Theory]
    [InlineData(36)]
    public void TestSumofSquares(long expected) {
        Assert.Equal(expected, Lib.getSquareOfSum(getTestSet()));
    }

    [Theory]
    [InlineData(18)]
    public void TestSquaresum(long expected) {
        Assert.Equal(expected, Lib.getSumOfSquares(getTestSet()));
    }

    public List<long> getTestSet() =>
        new List<long> {3, 3};

}