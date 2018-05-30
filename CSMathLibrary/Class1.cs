using System;

namespace CSMathLibrary
{
    public class CSMath
    {
        public static int Fib(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        public static long Count()
        {
            long i;
            for (i = 0; i < 1000000; i++) ;
            return i;
        }
    }
}
