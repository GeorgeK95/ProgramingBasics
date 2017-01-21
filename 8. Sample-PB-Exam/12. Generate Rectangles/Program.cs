using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            bool check = false;

            for (int i1 = -n; i1 < n; i1++)//left
            {
                for (int i2 = -n; i2 < n; i2++)//top
                {
                    for (int i3 = i1 + 1; i3 <= n; i3++)//right
                    {
                        for (int i4 = i2 + 1; i4 <= n; i4++)//bottom
                        {
                            int a = i3 - i1;
                            int b = i4 - i2;
                            int s = a * b;
                            if ((s >= m))
                            {
                                check = true;
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", i1, i2, i3, i4, s);
                            }
                        }

                    }

                }
                
            }
            if (!check)
            {
                Console.WriteLine("No");
            }
        }
    }
}
