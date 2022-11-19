
using System;
using ProjectEulerProblems.Problem_1;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests;

public class Problem1Tests {
    [Fact]
    public void Lib_ShouldThrowException_WithOutOfRangeParam()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Lib.ReturnMultiplesOf3And5(0));
    }

    [Theory]
    [InlineData(10, 23)]
    [InlineData(1000, 233168)]
    public void Lib_ShouldPass_WithRange_AndAnswer(int input, int expected) =>
        Assert.Equal(expected, Lib.ReturnSumOfMultiplesOf3And5(input));

    [Fact]
    public void Lib_ShouldThrow_ErrorWithInvalidInput() =>
        Assert.Throws<ArgumentOutOfRangeException>(() => Lib.ReturnSumOfMultiplesOf3And5(0));
}