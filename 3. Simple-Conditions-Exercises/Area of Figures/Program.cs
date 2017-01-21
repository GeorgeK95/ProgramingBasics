using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            //квадрат (square), правоъгълник (rectangle), кръг (circle) и триъгълник (triangle). 
            var figure = Console.ReadLine();
            double result = 0;

            if (figure.Equals("square"))
            {
                var a = double.Parse(Console.ReadLine());
                result = a * a;
            }
            else if (figure.Equals("rectangle"))
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                result = a * b;
            }
            else if (figure.Equals("circle"))
            {
                var rad = double.Parse(Console.ReadLine());
                result = Math.PI * rad * rad;
            }
            else if (figure.Equals("triangle"))
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                result = a * h;
                result /= 2;
            }
            Console.WriteLine(result);
        }
    }
}
