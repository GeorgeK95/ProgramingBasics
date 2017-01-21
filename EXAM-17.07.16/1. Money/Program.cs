using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * •	На първия ред – броят биткойни. Цяло число в интервала [0…20]
•	На втория ред – броят китайски юана. Реално число в интервала [0.00… 50 000.00]
•	На третия ред – комисионната. Реално число в интервала [0.00 ... 5.00]
*/

            var bitCoins = int.Parse(Console.ReadLine());
            var japanCeans = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());

            double bitCoinsLV = bitCoins * 1168;/*lv*/
            double CeansLV = japanCeans * 0.15;/*dollars*/
            CeansLV *= 1.76;

            double euroResult = (bitCoinsLV + CeansLV) / 1.95;
            double commisionResult = euroResult * commision / 100;

            Console.WriteLine(euroResult - commisionResult);

        }
    }
}
