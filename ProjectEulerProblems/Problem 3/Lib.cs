﻿namespace ProjectEulerProblems.Problem_3; 

public static class Lib
{
    public static IEnumerable<long> PrimeFactors(long input)
    {
        if(input < 1)
            throw new ArgumentOutOfRangeException(nameof(input), "Enter a number greater than 1");
        List<long> factors = new List<long>();

        while (input % 2 == 0)
            factors.Add(input >>= 1);


        for (long i = 3; i <= Math.Sqrt(input); i += 2) {
            while (input % i == 0) {
                factors.Add(i);
                input /= i;
            }
        }

        if(input > 1)
            factors.Add(input);

        return factors;

    }
}