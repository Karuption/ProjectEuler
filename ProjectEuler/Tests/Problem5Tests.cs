using System;
using ProjectEulerProblems.Problem_5;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests; 

public class Problem5Tests
{
    [Theory]
    [InlineData(2520, 10)]
    [InlineData(232792560, 20)]
    public void Test_LCM(int expected, int input) {
        Assert.Equal(expected, Lib.GetLCMUnderX(input));
    }

    [Fact]
    public void TestLCMThrows() {
        Assert.Throws<ArgumentOutOfRangeException>(() => Lib.GetLCMUnderX(0));
    }
}