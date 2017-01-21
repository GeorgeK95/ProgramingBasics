using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Входът се чете от конзолата и се състои от точно 4 реда:
•	1ви ред: X кв.м е лозето – цяло число в интервала [10 … 5000];
•	2ри ред: Y грозде за един кв.м – реално число в интервала [0.00 … 10.00];
•	3ти ред: Z нужни литри вино – цяло число в интервала [10 … 600];
•	4ти ред: брой работници – цяло число в интервала [1 … 20];

             * */

            var loze = int.Parse(Console.ReadLine());
            var grozdeZaMetar = double.Parse(Console.ReadLine());
            var nujniLitriVino = int.Parse(Console.ReadLine());
            var rabotnici = int.Parse(Console.ReadLine());

            double totalGrozde = loze * grozdeZaMetar;
            double vino = 0.4 * totalGrozde;
            double litriVino = vino / 2.5; //result

            if (litriVino >= nujniLitriVino)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(litriVino));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(litriVino - nujniLitriVino), Math.Ceiling((litriVino - nujniLitriVino) / rabotnici));
            }
            else if (litriVino < nujniLitriVino)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(nujniLitriVino - litriVino));
            }
        }
    }
}
