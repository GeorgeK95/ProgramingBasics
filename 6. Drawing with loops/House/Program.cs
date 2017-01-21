using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            printRoof(n);
            printBasis(n);
        }

        private static void printBasis(int n)
        {
            int basisRows = n / 2;

            for (int i = 0; i < basisRows; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1)
                    {
                        Console.Write('|');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }

        }

        private static void printRoof(int n)
        {
            int roofRows = (n + 1) / 2;
            int starsNum = starsNumInicialize(n);

            for (int i = 0; i < roofRows; i++)
            {
                int dashNum = n - starsNum;
                int forCounter = dashNum / 2;

                printDash(forCounter);
                printStars(starsNum);
                printDash(forCounter);

                starsNum += 2;
                Console.WriteLine();
            }

        }

        private static int starsNumInicialize(int n)
        {
            int starsNum;
            if (n % 2 == 0)
            {
                starsNum = 2;
            }
            else
            {
                starsNum = 1;
            }
            return starsNum;
        }

        private static void printStars(int starsNum)
        {
            for (int i2 = 0; i2 < starsNum; i2++)
            {
                Console.Write('*');
            }
        }

        private static void printDash(int dashNum)
        {
            for (int i1 = 0; i1 < dashNum; i1++)
            {
                Console.Write('-');
            }
        }
    }
}
