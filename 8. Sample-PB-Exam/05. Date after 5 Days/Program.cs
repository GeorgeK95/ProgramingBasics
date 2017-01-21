using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            int addDays = 5;

            d += addDays;

            if (d > 28)
            {
                if (m == 2 && d > 28)
                {
                    d -= 28;
                    m++;
                }
                else if ((m == 4 || m == 6 || m == 9 || m == 11) && d > 30)
                {
                    d -= 30;
                    m++;
                }
                else if ((m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) && d > 31)
                {
                    d -= 31;
                    m++;
                }
                printResult(d, m);
            }
            else
            {
                printResult(d, m);
            }
        }

        private static void printResult(int d, int m)
        {
            if (m > 12)
            {
                m -= 12;
            }

            if (m < 10)
            {
                Console.WriteLine(d + ".0" + m);
            }
            else
            {
                Console.WriteLine(d + "." + m);
            }
        }
    }
}
