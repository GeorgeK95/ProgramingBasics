using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Пеперуда
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            printUpPart(n, true);
            //middlePart
            Console.Write(new string(' ', n - 1));
            Console.WriteLine('@');
            printUpPart(n, false);

        }

        private static void printUpPart(int n, bool isUpPart)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                for (int i1 = 0; i1 < 2; i1++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(new string('*', n - 2));
                    }
                    else
                    {
                        Console.Write(new string('-', n - 2));
                    }
                    if (i1 == 0 && isUpPart)
                    {
                        Console.Write("\\ /");
                    }
                    else if (i1 == 0 && !isUpPart)
                    {
                        Console.Write("/ \\");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
