using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaPractice
{
    internal class Recursion
    {
        long[] fibCache; // = new long[n + 1];
        long FibonacciNumber(int n)
        {
            if (n <= 1)
            {
                //Console.Write(n + " ");
                return n;
            }
            if (fibCache[n] != 0)
            {
                //Console.Write(n + " ");
                return fibCache[n];
            }
            long nthFib = FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
            fibCache[n] = nthFib;
            //Console.Write(nthFib + " ");
            return nthFib;
        }

        public long CallFibonacciNumber(int n)
        {
            fibCache = new long[n+1];
            return FibonacciNumber(n);
        }
    }
}
