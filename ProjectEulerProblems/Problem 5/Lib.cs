namespace ProjectEulerProblems.Problem_5; 

public static class Lib
{
    public static long GetLCMUnderX(long input)
    {
        if(input < 3)
            throw new ArgumentOutOfRangeException(nameof(input), "The range must be above 3");
        long temp = GetLCM(input, input - 1);

        for (long i = input-2; i > 1; i--)
        {
            temp = GetLCM(temp, i);
        }

        return temp;
    }
    public static long GetLCM(long first, long second)
    {
        return (first * second) / GetGCD(first, second);
    }

    public static long GetGCD(long first, long second)
    {
        var tmpx = Math.Max(first,second); var tmpy = Math.Min(first, second);

        while (tmpx != tmpy)
            if (tmpx > tmpy)
                tmpx -= tmpy;
            else
                tmpy -= tmpx;

        return tmpx;
    }
}