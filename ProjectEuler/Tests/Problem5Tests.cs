
using System;
using Xunit;

namespace ProjectEuler.Tests
{
    public class Problem5Tests
    {
        [Theory]
        [InlineData(2520, 10)]
        [InlineData(232792560, 20)]
        public void Test_LCM(int expected, int input)
        {
            Assert.Equal(expected, Problem5.Lib.GetLCMUnderX(input));
        }

        [Fact]
        public void TestLCMThrows() =>
            Assert.Throws<ArgumentOutOfRangeException>(()=>Problem5.Lib.GetLCMUnderX(0));


    }
}