using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Лице_на_триъгълник_в_равнината
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            double a = 0;
            double s = 0;
            double h = 0;

            if (y2 == y3)
            {
                a = Math.Abs(x2 - x3);
                h = Math.Abs(y1 - y2);
                s = (a * h) / 2;
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Incorrect data (y2 shoud be qeual to y3)");
            }
        }
    }
}
