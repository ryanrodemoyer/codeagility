using System;

namespace CodingAgility.BitRev
{
    public class BitRev
    {
        public static int BitReverse(int n)
        {
            char[] charArray = Convert.ToString(n, 2).ToCharArray();
            Array.Reverse(charArray); 

            return Convert.ToInt32(new string(charArray), 2);
        }

        public static long SymmetricBinaryRoot(int d)
        {
            int searchUpperBounds = (int) Math.Round(Math.Sqrt(d), MidpointRounding.AwayFromZero);

            for (int i = 1; i <= searchUpperBounds; i++)
            {
                long product = i*BitReverse(i);
                if (product == d)
                {
                    return product;
                }
            }

            return -1;
        }
    }
}
