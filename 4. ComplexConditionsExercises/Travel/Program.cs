using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season.Equals("summer"))
                {
                    Console.WriteLine("Camp - " + string.Format("{0:0.00}", budget * 0.3));
                    //Console.WriteLine("Camp - " + Math.Round( budget * 0.3, 2)); //30%
                }
                else if (season.Equals("winter"))
                {
                    Console.WriteLine("Hotel - " + string.Format("{0:0.00}", budget * 0.7));
                    //Console.WriteLine("Hotel - " + Math.Round(budget * 0.7, 2));
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season.Equals("summer"))
                {
                    Console.WriteLine("Camp - " + string.Format("{0:0.00}", budget * 0.4));
                    //Console.WriteLine("Camp - " + Math.Round(budget * 0.4, 2)); //40%
                }
                else if (season.Equals("winter"))
                {
                    Console.WriteLine("Hotel - " + string.Format("{0:0.00}", budget * 0.8));
                    //string.Format("{0:0.00}", budget * 0.8);
                    //Console.WriteLine("Hotel - " + Math.Round( budget * 0.8, 2));
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                //Console.WriteLine("Hotel - " + Math.Round(0.9 * budget, 2));
                Console.WriteLine("Hotel - " + string.Format("{0:0.00}", budget * 0.9));
            }
        }
    }
}
