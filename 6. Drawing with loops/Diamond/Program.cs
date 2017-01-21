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
            
            printUpPart(n);
            Console.WriteLine("______________________________________________");
            printDownPart(n);
        }

        private static void printDownPart(int n)
        {
            int starIndex = (n) / 2;//4
            int startForCycle = 0;

            if (n % 2 != 0)
            {
                startForCycle = (n - 1) / 2;
            }
            else
            {
                startForCycle = (n) / 2;
            }

            for (int i = (n)/2 ; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == starIndex - i || j == starIndex + i)
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

        private static void printUpPart(int n)
        {
            int starIndex = (n - 1) / 2; //3

            for (int i = 1; i <= n / 2; i++) //4
            {
                for (int j = 0; j < n; j++) //8
                {
                    if (j == starIndex|| j == starIndex + i)
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
    }
}
