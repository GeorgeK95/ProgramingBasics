using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	На първия ред са необходимите часовете – цяло число в интервала [0 ... 200 000]
•	На втория ред са дните, с които фирмата разполага – цяло число в интервала [0 ... 20 000]
•	На третия ред е броят на служителите, работещи извънредно – цяло число в интервала [0 ... 200]
*/

            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            double realWorlHours = (days - 0.1 * days) * 8;
            double overTimeHours = workers * 2 * days;

            int allHours = (int)(realWorlHours + overTimeHours);

            int differenceHours = hours - allHours;
            if (differenceHours < 0)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Abs(differenceHours));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(differenceHours));
            }
        }
    }
}
