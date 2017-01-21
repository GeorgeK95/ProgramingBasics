using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchukova_borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var a1 = int.Parse(Console.ReadLine());
            var b1 = int.Parse(Console.ReadLine());

            Console.WriteLine(((a1 * a) + (b1 * b)) / 1.94);
        }
    }
}
