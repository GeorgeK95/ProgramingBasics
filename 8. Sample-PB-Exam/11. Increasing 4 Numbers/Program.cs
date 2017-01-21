using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 3)
            {
                Console.WriteLine("no");
            }

            for (int i = a; i <= b - 3; i++)
            {
                for (int i1 = i; i1 <= b - 2; i1++)
                {
                    for (int i2 = i1; i2 <= b - 1; i2++)
                    {
                        for (int i3 = i2; i3 <= b; i3++)
                        {
                            if (i < i1 && i1 < i2 && i2 < i3)
                            {
                                Console.WriteLine(i + " " + i1 + " " + i2 + " " + i3);    
                            }
                        }

                    }
                    
                }
            }

        }
    }
}
