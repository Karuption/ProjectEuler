
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Tests
{
    public class Problem3Tests
    {
        [Fact]
        public void Test_Generate_Sample()
        {
            //factors of 13195 are 5, 7, 13 and 29
            List<int> expected = new List<int> {5, 7, 13, 29};
            Assert.Equal(expected.Max(), Problem3.Lib.PrimeFactors(13195).Max());
        }

        [Fact]
        public void testThrows() =>
            Assert.Throws<ArgumentOutOfRangeException>(()=>Problem3.Lib.PrimeFactors(0));

    }
}