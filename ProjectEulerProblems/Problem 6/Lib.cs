namespace ProjectEulerProblems.Problem_6;

public static class Lib {
    public static long SumSquareDifference(long input) {
        List<long> squares = new();

        for (var i = 1; i <= input; i++)
            squares.Add(i);

        return getSquareOfSum(squares) - getSumOfSquares(squares);
    }

    public static long getSumOfSquares(List<long> squares) {
        long temp = 0;

        foreach (var square in squares)
            temp += square * square;

        return temp;
    }

    public static long getSquareOfSum(List<long> sumsq) {
        long temp = 0;

        for (var i = 0; i < sumsq.Count(); i++)
            temp += sumsq[i];

        return temp * temp;
    }
}