using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int counter = 0;

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 1; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter >= 2)
                {
                    Console.WriteLine("Not Prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
            
        }
    }
}
