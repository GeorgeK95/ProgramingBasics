using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = {0}\nPerimeter = {1}", Math.PI * r * r, 2 * Math.PI * r);
        }
    }
}
