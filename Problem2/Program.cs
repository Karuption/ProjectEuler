using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Lib.SumOfEvenValues(Lib.GenerateSequence(4000000)));
            Console.Read();
        }
    }
}
