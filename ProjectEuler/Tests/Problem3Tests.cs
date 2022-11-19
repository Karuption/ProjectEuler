using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerProblems.Problem_3;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests; 

public class Problem3Tests
{
    [Fact]
    public void Test_Generate_Sample()
    {
        //factors of 13195 are 5, 7, 13 and 29
        List<int> expected = new List<int> {5, 7, 13, 29};
        Assert.Equal(expected.Max(), Lib.PrimeFactors(13195).Max());
    }

    [Fact]
    public void testThrows() {
        Assert.Throws<ArgumentOutOfRangeException>(() => Lib.PrimeFactors(0));
    }
}