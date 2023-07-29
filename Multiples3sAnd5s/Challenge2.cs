using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3sAnd5s
{
    internal class Challenge2
    {
        static void Main(string[] args)
        {
            int val1 = 0, val2 = 1, val3, i, n;

            n = 10;

            Console.WriteLine("1st ten Fibonacci numbers:");
            Console.Write(val1 + " " + val2 + " ");

            for (i = 2; i < n; ++i)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }

            Console.ReadLine();

                long[] arr = new long[1000000];
            long t = 2;
            arr[i - 2] = 1;
            arr[i - 1] = 2;
            long g = arr[i];

            long s = 0;
            for (i = 2; n <= 4000000; i++)
            {
                arr[i] = arr[(i - 1)] + arr[(i - 2)];
            }
            for (long f = 0; f <= arr.Length - 1; f++)
            {
                if (arr[f] % 2 == 0)
                    s += arr[f];
            }
            Console.Write(s);
            Console.Read();
        }
    }
}
