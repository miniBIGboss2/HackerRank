using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main()
        {
            var input = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(LongFactorials.LongFact(input));
        }
    }
}