using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            double result = 0; //meters

            if (input.Equals("km"))
            {
                result = num * 1000;
            }
            else if (input.Equals("mm"))
            {
                result = num * 0.001;
                Console.WriteLine(result);
            }
            else if (input.Equals("cm"))
            {
                result = num * 0.01;
            }
            else if (input.Equals("mi"))
            {
                result = num * 1609.34;
                //Console.WriteLine(result);
            }
            else if (input.Equals("in"))
            {
                result = num * 0.0254;
            }
            else if (input.Equals("ft"))
            {
                result = num * 0.3048;
            }
            else if (input.Equals("yd"))
            {
                result = num * 0.9144;
            }
            else if (input.Equals("yd"))
            {
                result = num * 0.9144;
            }
            else if (input.Equals("m"))
            {
                result = num * 1;
            }




            if (output.Equals("mm"))
            {
                result *= 1000;
            }
            else if (output.Equals("cm"))
            {
                result *= 100;
            }
            else if (output.Equals("m"))
            {
                result = num;
            }
            else if (output.Equals("mi"))
            {
                result *= 0.000621371192;
            }
            else if (output.Equals("in"))
            {
                result *= 39.3700787;
            }
            else if (output.Equals("km"))
            {
                result *= 0.001;
            }
            else if (output.Equals("ft"))
            {
                result *= 3.2808399;
            }
            else if (output.Equals("yd"))
            {
                result *= 1.0936133;
            }

            Console.WriteLine(result);
        }
    }
}
