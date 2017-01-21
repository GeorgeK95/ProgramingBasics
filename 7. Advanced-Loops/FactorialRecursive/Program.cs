using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int result = findFactorial(n);
            Console.WriteLine(result);
        }

        private static int findFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * findFactorial(n - 1);
        }
    }
}
