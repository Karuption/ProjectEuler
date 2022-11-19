namespace ProjectEulerProblems.Problem_4; 

public static class Lib
{
    public static bool CheckPalindrome(long input) {
        var number = input.ToString();

        for (var i = 0; i < number.Length / 2; i++)
            if (number[i] != number[number.Length - i - 1])
                return false;
        return true;
    }

    public static long FindXDigitPalindrome(int length)
    {
        if(length < 1)
            throw new ArgumentOutOfRangeException(nameof(length));

        long largest = GetSmallestPalindromeByDigit(length), check;
        int initial = GetLargestNumberByDigit(length);

        for (int i = initial; i > 9; i--)
        {
            for (int j = initial; j > 9; j--)
            {
                check = i * j;

                if (check > largest)
                {
                    if (CheckPalindrome(check))
                        largest = check;
                }
                else
                    break;

            }
        }

        return largest;
    }

    public static int GetLargestNumberByDigit(int length)
    {
        if(length < 1)
            throw new ArgumentOutOfRangeException(nameof(length), "The Number of digits has to be greater than 0");

        return (int)Math.Pow(10, length) - 1;
    }

    public static int GetSmallestPalindromeByDigit(int baseSize)
    {
        if(baseSize < 1)
            throw new ArgumentOutOfRangeException(nameof(baseSize));

        var strlen = baseSize * 2 - 2;

        return int.Parse(string.Join("", "1", new string('0', strlen), "1"));
    }
}