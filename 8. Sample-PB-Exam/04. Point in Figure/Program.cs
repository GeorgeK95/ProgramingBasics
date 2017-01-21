using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if (checkRectangle1(x, y) || checkRectangle2(x, y))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }

        private static bool checkRectangle1(int x, int y)
        {
            bool returnValue = true;

            if (x > 10 || x < 4 || y >  3 || y < -5)
            {
                returnValue = false;
            }

            return returnValue;
        }

        private static bool checkRectangle2(int x, int y)
        {
            bool returnValue = true;

            if (x > 12 || x < 2 || y > 1 || y < -3)
            {
                returnValue = false;
            }

            return returnValue;
        }
    }
}
