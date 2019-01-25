using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Problem1
{
    public static class Lib
    {
        public static IEnumerable<int> ReturnMultiplesOf3And5(int range)
        {
            if (range < 3)
                throw new ArgumentOutOfRangeException(nameof(range));

            return Enumerable
                .Range(3, range-3)
                .Where(x => (x % 3 == 0 || x % 5 == 0));
        }

        public static int ReturnSumOfMultiplesOf3And5(int range) =>
            ReturnMultiplesOf3And5(range).Sum();

    }
}