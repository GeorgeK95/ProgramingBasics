using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var first = 0;
            var second = 0;

            if (f < s)
            {
                first = f;
                second = s;
            }
            else
            {
                first = s;
                second = f;
            }

            int diffToFirst = Math.Abs(first - point);
            int diffToSecond = Math.Abs(second - point);

            if (point >= first && point <= second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            if (diffToFirst < diffToSecond)
            {
                Console.WriteLine(diffToFirst);
            }
            else
            {
                Console.WriteLine(diffToSecond);
            }
            
        }
    }
}
