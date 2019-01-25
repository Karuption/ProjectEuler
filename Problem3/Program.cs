using System;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Lib.PrimeFactors(600851475143).Max().ToString());
            Console.ReadLine();
        }
    }
}
