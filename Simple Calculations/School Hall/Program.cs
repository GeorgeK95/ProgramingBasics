using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            //integer takers for w and h to take only the whole part 
            int w1 = 0;
            int h1 = 0;
            //turning w and h to sm
            w *= 100;
            h *= 100;
            //taking 1 meter for the coridor
            h -= 100;
            //taking the whole part
            w1 = (int)w / 120;
            h1 = (int)h / 70;

            Console.WriteLine((w1 * h1) - 3);
        }
    }
}
