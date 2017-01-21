using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Магически_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int magicNum = 9;

            for (int i1 = 1; i1 <= magicNum; i1++)
            {
                for (int i2 = 1; i2 <= magicNum; i2++)
                {
                    for (int i3 = 1; i3 <= magicNum; i3++)
                    {
                        for (int i4 = 1; i4 <= magicNum; i4++)
                        {
                            for (int i5 = 1; i5 <= magicNum; i5++)
                            {
                                for (int i6 = 1; i6 <= magicNum; i6++)
                                {
                                    if ((i1 * i2 * i3 * i4 * i5 * i6) == n)
                                    {
                                        Console.Write(i1 + "" + i2 + "" + i3 + "" + i4 + "" + i5 + "" + i6 + " ");
                                    }
                                }

                            }

                        }

                    }

                }

            }
        }
    }
}
