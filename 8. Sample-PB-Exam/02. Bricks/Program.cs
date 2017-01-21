using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine()); //broi tuhli
            var w = int.Parse(Console.ReadLine()); //broi rabotnici
            var m = int.Parse(Console.ReadLine()); //vmestimost na koli4kata

            double result = x / (w * m);

            if (w * m * result == x)
            {
                Console.WriteLine(result);
            }
            else if (w * m * result < x)
            {
                Console.WriteLine(result + 1);
            }
            else if (result > 0 && result < 1)
            {
                Console.WriteLine(1);
            }
        }
    }
}
