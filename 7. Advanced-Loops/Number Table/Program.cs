using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int j = 1;

            for (int i = 1; i <= n; i++)
            {
                for (j = i; j <= n; j++)
                {
                    Console.Write(j + " ");
                    
                }
                if (i != 1)
                {
                    for (int i1 = n - 1; i1 >= j - i; i1--)
                    {
                        Console.Write(i1 + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
