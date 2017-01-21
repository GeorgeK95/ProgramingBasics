using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isPrime = checkForPrime(n);
            //drawing the first line
            Console.WriteLine(new string('%', 2 * n));
            //drawling the middle part
            if (isPrime)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (i == n / 2 - 1)
                    {
                        Console.Write('%');
                        int intervalLength = n - 2;
                        Console.Write(new string(' ', intervalLength));
                        Console.Write("**");
                        Console.Write(new string(' ', intervalLength));
                        Console.Write('%');
                    }
                    else
                    {
                        Console.Write('%');
                        Console.Write(new string(' ', (2 * n) - 2));
                        Console.Write('%');
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == n / 2)
                    {
                        Console.Write('%');
                        int intervalLength = n - 2;
                        Console.Write(new string(' ', intervalLength));
                        Console.Write("**");
                        Console.Write(new string(' ', intervalLength));
                        Console.Write('%');
                    }
                    else
                    {
                        Console.Write('%');
                        Console.Write(new string(' ', (2 * n) - 2));
                        Console.Write('%');
                    }
                    Console.WriteLine();
                }
            }

            //drawing the last line
            Console.WriteLine(new string('%', 2 * n));
        }

        private static bool checkForPrime(int n)
        {
            bool isPrime = true;
            if (n % 2 != 0)
            {
                isPrime = false;
            }
            return isPrime;
        }
    }
}
