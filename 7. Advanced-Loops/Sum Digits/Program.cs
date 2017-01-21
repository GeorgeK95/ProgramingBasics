using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int result = 0;
            while (n >= 1)
            {
                result += n % 10;
                n /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
