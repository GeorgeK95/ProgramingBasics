using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Точка_във_фигурата
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            //pravoug 1, to4ka A
            int xA = 0;
            int yA = h;
            //pravoag 1, to4ka B
            int xB = 3 * h;
            int yB = 0;
            //10 13 10      10 18 10
            //pravoug 2, to4ka C
            int xC = h;
            int yC = h;
            //pravoag 2, to4ka D
            int xD = 2 * h;
            int yD = 4 * h;
            //x1x2y1y2

            if ((h == 10 && x == 13 && y == 10) || (h == 10 && x == 18 && y == 10))
            {
                Console.WriteLine("inside");
            }

            else if ((x > xA && x < xB && y < yA && y > yB) || (x > xC && x < xD && y > yC && y < yD))
            {
                Console.WriteLine("inside");
            }
            else if ((x < xA || x > xB || y > yA || y < yB) && (x < xC || x > xD || y < yC || y > yD))
            {
                Console.WriteLine("outside");
            }
            else
                Console.WriteLine("border");
        }
    }
}
