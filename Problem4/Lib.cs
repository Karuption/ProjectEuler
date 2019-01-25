using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problem4
{
    public static class Lib
    {
        public static bool CheckPalindrome(long input)
        {
            string reversed = new string(input.ToString().Reverse().ToArray());
            return input.ToString().Equals(reversed);
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
            int initial = 10;

            while (--length > 0)
                initial *= 10;

            return initial-1;
        }

        public static int GetSmallestPalindromeByDigit(int baseSize)
        {
            if(baseSize < 1)
                throw new ArgumentOutOfRangeException(nameof(baseSize));

            String digitS = "1";
            int strlen = baseSize * 2 - 2;

            while (strlen-- > 0)
                digitS = String.Concat(digitS, "0");

            digitS = String.Concat(digitS, "1");

            return Int32.Parse(digitS);
        }
    }
}
