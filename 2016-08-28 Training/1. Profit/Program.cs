using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine()); //5-30
            var m = decimal.Parse(Console.ReadLine()); //10-2000
            var course = decimal.Parse(Console.ReadLine());//0.99-1.99

            decimal monthPayment = (decimal)n * (decimal)m;
            decimal yearPayment = monthPayment * 12;
            yearPayment += (decimal)2.5 * (decimal)monthPayment;
            decimal dds = (decimal)0.25 * (decimal)yearPayment;
            yearPayment -= dds;
            decimal dayProfit = yearPayment / 365;
            Console.WriteLine(Math.Round((decimal)dayProfit * (decimal)course, 2));
        }
    }
}
