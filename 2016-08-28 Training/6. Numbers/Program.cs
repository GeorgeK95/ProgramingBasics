using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int x = number / 100;
            int y = number / 10;
            y %= 10;
            int z = number % 10;

            int rows = x + y;
            int cows = x + z;

            int result = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cows; j++)
                {
                    if (number % 5 == 0)
                    {
                        number -= x;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= y;
                    }
                    else
                    {
                        number += z;
                    }
                    Console.Write(number + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
