using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (town.Equals("sofia"))
            {
                if (quantity >= 0 && quantity <= 500)
                {
                    Console.WriteLine(Math.Round(quantity * 0.05, 2));
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.07, 2));
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.08, 2));
                }
                else if (quantity > 10000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.12, 2));
                }
            }
            else if (town.Equals("plovdiv"))
            {
                if (quantity >= 0 && quantity <= 500)
                {
                    Console.WriteLine(Math.Round(quantity * 0.055, 2));
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.08, 2));
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.12, 2));
                }
                else if (quantity > 10000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.145, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town.Equals("varna"))
            {
                if (quantity >= 0 && quantity <= 500)
                {
                    Console.WriteLine(Math.Round(quantity * 0.045, 2));
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.075, 2));
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.10, 2));
                }
                else if (quantity > 10000)
                {
                    Console.WriteLine(Math.Round(quantity * 0.13, 2));
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
