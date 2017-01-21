using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Генератор_за_тъпи_пароли
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            char[] alphabet = {'a', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i1 = 1; i1 < n; i1++)
            {
                for (int i2 = 1; i2 < n; i2++)
                {
                    for (int i3 = 1; i3 <= l; i3++)
                    {
                        for (int i4 = 1; i4 <= l; i4++)
                        {
                            for (int i5 = i1; i5 <= n; i5++)
                            {
                                if (i5 > i1 && i5 > i2)
                                {
                                    Console.Write(i1 + "" + i2 + "" + alphabet[i3] + "" + alphabet[i4] + "" + i5 + " ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
