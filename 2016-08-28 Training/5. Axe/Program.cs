using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            drawUpPart(n);
            drawMiddlePart(n);
            drawDownPart(n);

        }

        private static void drawDownPart(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', 3 * n - i));
                Console.Write('*');
                if (i == n / 2 - 1)
                {
                    Console.Write(new string('*', n - 1 + 2 * i));
                }
                else
                {
                    Console.Write(new string('-', n - 1 + 2 * i));
                }
                
                Console.Write('*');
                Console.Write(new string('-', n - i - 1));
                Console.WriteLine();
            }
        }

        private static void drawMiddlePart(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', 3 * n + 1));
                Console.Write(new string('-', n - 1));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', n - 1));
                Console.WriteLine();
            }
            
        }

        private static void drawUpPart(int n)
        {
            for (int i = 0; i < n; i++)
            {
                //for (int i1 = 0; i1 < 5 * n; i1++)
                //{
                    Console.Write(new string('-', 3 * n));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', i));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', 5 * n - (i + 2 + (3 * n))));
                //}
                Console.WriteLine();

            }
        }
    }
}
