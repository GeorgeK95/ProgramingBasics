using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine('*');
            }
            else
            {
                printUpperPart(n - 1);
                printDownPart(n - 1);
            }
        }

        private static void printDownPart(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                generateSpaces(n - i);
                Console.Write('*');
                for (int i1 = 0; i1 < i; i1++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            generateSpaces(n);
            Console.WriteLine('*');
        }

        private static void printUpperPart(int n)
        {
            generateSpaces(n);
            Console.WriteLine('*');

            for (int i = 1; i <= n; i++)
            {
                generateSpaces(n - i);
                Console.Write('*');
                for (int i1 = 0; i1 < i; i1++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

        }

        private static void generateSpaces(int p)
        {
            Console.Write(new string(' ', p));
        }
    }
}
