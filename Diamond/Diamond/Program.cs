using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isEven = isEvenMethod(n);
            if (isEven)
            {
                printDiamondForOddInput(n);
            }
            else
            {
                printDiamondForEvenInput(n);
            }

        }

        private static void printDiamondForOddInput(int n)
        {
            printUpPartOdd(n);
            printDownPartOdd(n);
        }

        private static void printDownPartOdd(int n)
        {
            int rowsNum = (n - 1) / 2;

            for (int i = 1; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i || j == n - i - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
        }

        private static void printUpPartOdd(int n)
        {
            int halfPart = (n - 1) / 2;
            for (int i = 0; i <= halfPart; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == halfPart - i || j == halfPart + 1 + i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
        }

        private static void printDiamondForEvenInput(int n)
        {
            printUpPartEven(n);
            printDownPartEven(n);
        }

        private static void printDownPartEven(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i || j == n - i - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
        }

        private static void printUpPartEven(int n)
        {
            int halfPart = n / 2;
            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == halfPart - i || j == halfPart + i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
        }

        private static bool isEvenMethod(int n)
        {
            bool result = true;
            if (n % 2 != 0)
            {
                result = false;
            }
            return result;
        }
    }
}
