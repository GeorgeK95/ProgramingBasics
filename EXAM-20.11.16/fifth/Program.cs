using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            up(n);
            middle(n);
            down(n);
        }

        private static void down(int n)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i));
                Console.Write(new string('\\', 1));
                Console.Write(new string('*', 2 * n - 1 - c));
                Console.Write(new string('/', 1));
                Console.Write(new string('-', i));
                c += 2;
                Console.WriteLine();
            }
        }

        private static void middle(int n)
        {
            int c = 0;
            for (int i = 0; i < n / 3; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', n / 2 + i));
                Console.Write(new string('\\', 1));
                Console.Write(new string('*', n - c));
                Console.Write(new string('/', 1));
                Console.Write(new string('*', n / 2 + i));
                Console.Write(new string('|', 1));
                Console.WriteLine();
                c += 2;
            }
        }

        private static void up(int n)
        {
            int c = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', i));
                Console.Write(new string('\\', 1));
                Console.Write(new string('-', 2 * n - c));
                Console.Write(new string('/', 1));
                Console.Write(new string('*', i));
                c += 2;
                Console.WriteLine();
            }
        }
    }
}
