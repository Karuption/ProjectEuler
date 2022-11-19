using System;
using ProjectEulerProblems.Problem_4;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests; 

public class Problem4Tests
{
    [Theory]
    [InlineData(9009)]
    [InlineData(1001)]
    [InlineData(5445)]
    public void CheckPalindrome_Test(long input) {
        Assert.True(Lib.CheckPalindrome(input));
    }

    [Theory]
    [InlineData((long) 9009, 2)]
    [InlineData((long)906609, 3)]
    public void CheckXDigitPalindrome(long expected, int length) {
        Assert.Equal(expected, Lib.FindXDigitPalindrome(length));
    }

    [Theory]
    [InlineData(1001, 2)]
    [InlineData(11, 1)]
    [InlineData(100001, 3)]
    public void CheckLowestPalindrome(int expected, int length) {
        Assert.Equal(expected, Lib.GetSmallestPalindromeByDigit(length));
    }

    [Theory]
    [InlineData(1, 9)]
    [InlineData(2, 99)]
    [InlineData(3, 999)]
    public void CheckHighestDigit(int digits, int expected) {
        Assert.Equal(expected, Lib.GetLargestNumberByDigit(digits));
    }

    [Fact]
    public void CheckHighestDigitthrows() {
        Assert.Throws<ArgumentOutOfRangeException>(() => Lib.GetLargestNumberByDigit(0));
    }

    [Fact]
    public void CheckGetXD() {
        Assert.Throws<ArgumentOutOfRangeException>(() => Lib.FindXDigitPalindrome(0));
    }

    [Fact]
    public void CheckGetSmallest() {
        Assert.Throws<ArgumentOutOfRangeException>(() => Lib.GetSmallestPalindromeByDigit(0));
    }
}