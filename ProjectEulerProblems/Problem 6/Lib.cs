namespace ProjectEulerProblems.Problem_6; 

public static class Lib
{
    public static long SumSquareDifference(long input)
    {
        List<long> squares = new List<long>();
        List<long> sumSquares;

        for (int i = 1; i <= input; i++)
            squares.Add(i);

        sumSquares = squares;
        //end variable initialization

        return getSquareOfSum(squares) - getSumOfSquares(sumSquares);
    }

    public static long getSumOfSquares(IEnumerable<long> squares)
    {
        long temp = 0;
        foreach (var square in squares)
        {
            temp += square * square;
        }

        return temp;
    }

    public static long getSquareOfSum(IEnumerable<long> sumsq)
    {
        long temp = sumsq.Sum();
        return temp*temp;
    }
}