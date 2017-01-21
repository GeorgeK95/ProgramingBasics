using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Чертане_на_крепост
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            printUpperPart(n);
            printMiddlePart(n);
            printDownPart(n);
        }

        private static void printDownPart(int n)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write('\\');
                for (int i1 = 0; i1 < n / 2; i1++)
                {
                    Console.Write('_');
                }
                Console.Write('/');
                int diff = Math.Abs(((n / 2) + 2) * 2 - (2 * n));
                if (i == 0)
                {
                    for (int i2 = 0; i2 < diff; i2++)
                    {
                        Console.Write(' ');
                    }
                }
            }
        }

        private static void printMiddlePart(int n)
        {
                for (int i = 0; i < n - 2; i++)
                {
                    int diff = Math.Abs(((n / 2) + 2) * 2 - (2 * n));
                    Console.Write('|');
                    Console.Write(new string(' ', (n / 2) + 1));
                    if (i == n - 3)
                    {
                        Console.Write(new string('_', diff));
                    }
                    else
                    {
                        Console.Write(new string(' ', diff));
                    }
                    Console.Write(new string(' ', (n / 2) + 1));
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 || j == 2 * n)
                        {
                            Console.Write('|');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
        }

        private static void printUpperPart(int n)
        {
            for (int i = 0; i < 2; i++)
            {
                int lineSymbolsNum = 2 * n;
                Console.Write('/');
                Console.Write(new string('^', n / 2));
                Console.Write('\\');
                int diff = Math.Abs(((n / 2) + 2) * 2 - (2 * n));
                if (i == 0)
                {
                    for (int i1 = 0; i1 < diff; i1++)
                    {
                        Console.Write('_');
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
