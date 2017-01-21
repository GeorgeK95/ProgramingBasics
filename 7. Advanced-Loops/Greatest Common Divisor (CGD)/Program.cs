using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int ost = 1;

            while (ost != 0)
            {
                ost = a % b;
                a = b;
                b = ost;
            }

            Console.WriteLine(a);
        }
    }
}
