using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter n: ");
            var n = decimal.Parse(Console.ReadLine());

            if (n < 2 || n > 100)
            {
                Console.WriteLine("N must be in interval: 2-100.");
            }
            else
            {


                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0 || i == n - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            if (j == 0 || j == n - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
