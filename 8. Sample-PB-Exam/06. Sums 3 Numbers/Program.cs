using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                if (a < b)
                {
                    printResult(a, b, c);    
                }
                else
                {
                    printResult(b, a, c);
                }
            }
            else if (b + c == a)
            {
                if (b < c)
                {
                    printResult(b, c, a);    
                }
                else
                {
                    printResult(c, b, a);
                }
            }
            else if (a + c == b)
            {
                if (a < c)
                {
                    printResult(a, c, b);    
                }
                else
                {
                    printResult(c, a, b);
                }
                
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        private static void printResult(int x, int y, int z)
        {
            Console.WriteLine(x + " + " + y + " = " + z);
        }
    }
}
