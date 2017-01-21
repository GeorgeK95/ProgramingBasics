using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            upPart(n);
            downPart(n);
        }

        private static void upPart(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', n - i));
                    Console.Write(new string('*', 3 * n));
                    Console.Write(new string('.', n - i));
                    Console.WriteLine();
                    Console.Write(new string('.', n - i - 1));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', 3 * n + 2 * i));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', n - i - 1));
                    Console.WriteLine();
                }
                else if (i == n - 1)
                {
                    Console.Write(new string('.', n - i - 1));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('*', 3 * n + 2 * i));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', n - i - 1));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('.', n - i - 1));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', 3 * n + 2 * i));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', n - i - 1));
                    Console.WriteLine();
                }
                
            }
        }

        private static void downPart(int n)
        {
            for (int i = 1; i <= 2 * n + 1; i++)
            {
                if (i == 2 * n + 1)
                {
                    Console.Write(new string('.', 2 * n + 1));
                    Console.Write(new string('*', 5 * n - (4 * n + 2)));
                    Console.Write(new string('.', 2 * n + 1));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', 4 * n - 2 * i + n - 2));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', i));
                    Console.WriteLine();
                }
                
            }
        }
    }
}
