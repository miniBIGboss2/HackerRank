using System.Numerics;

namespace ExtraLongFactorials
{
    public class LongFactorials
    {
        public static BigInteger LongFact(BigInteger input)
        {
            if (input == 0)
            {
                return 1;
            }
            else
            {
                return input * LongFact(input - 1);
            }
        }
    }
}