using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Знак_СТОП
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            printUpPart(n);
            printDownPart(n);
        }

        private static void printDownPart(int n)
        {
            int addent = 2;
            printFirstRow(n);
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("\\\\");
                Console.Write(new string('_', (4 * n + 3) - 4 - addent));
                Console.Write("//");
                Console.WriteLine(new string('.', i));
                addent += 2;
            }
        }

        private static void printFirstRow(int n)
        {
            Console.Write("\\\\");
            Console.Write(new string('_', (4 * n) - 1));
            Console.WriteLine("//");
        }

        private static void printUpPart(int n)
        {
            printFirstLine(n);
            int addend = 0;
            for (int i = n; i >= 0; i--)
            {

                Console.Write(new string('.', i));
                Console.Write("//");
                if (i == 0)
                { 
                    Console.Write(new string('_', ((2 * n) - 3)));
                    Console.Write("STOP!");
                    Console.Write(new string('_', ((2 * n) - 3)));
                    Console.WriteLine("\\\\");
                }
                else
                {
                    Console.Write(new string('_', ((2 * n) - 1) + addend));
                    Console.Write("\\\\");
                    addend += 2;
                    Console.WriteLine(new string('.', i));
                }
            }
        }

        private static void printFirstLine(int n)
        {
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', (2 * n) + 1));
            Console.WriteLine(new string('.', n + 1));
        }
    }
}
