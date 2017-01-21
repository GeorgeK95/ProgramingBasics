using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont_na_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * •	N – дължината на страна от площадката в интервала [1...100]
•	W – широчината на една плочка в интервала [0.1...10.00]
•	L – дължината на една плочка в интервала [0.1...10.00]
•	М – широчината на пейката в интервала [0...10]
•	О – дължината на пейката в интервала [0...10]
*/

            var N = int.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var O = int.Parse(Console.ReadLine());

            if (N < 1 || N > 100 || W < 0.1 || W > 10.00 || L < 0.1 || L > 10.00 || M < 0 || M > 10 || O < 0 || O > 10)
            {
                Console.WriteLine("Incorrect data.");
            }
            else
            {
                var Sland = N * N;
                var Sbench = O * M;
                var Splate = L * W;
                var result = (Sland - Sbench) / Splate;
                Console.WriteLine("Needed plates: " + result);
                Console.WriteLine("Needed time : " + result * 0.2);
            }

        }
    }
}
