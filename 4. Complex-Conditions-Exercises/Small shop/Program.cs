using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            town = town.ToLower();
            product = product.ToLower();

            if (town.Equals("sofia"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(quantity * 0.5);
                }
                else if (product.Equals("water"))
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(quantity * 1.60);
                }
            }
            else if (town.Equals("plovdiv"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(quantity * 0.4);
                }
                else if (product.Equals("water"))
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(quantity * 1.50);
                }
            }
            else if (town.Equals("varna"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(quantity * 0.45);
                }
                else if (product.Equals("water"))
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(quantity * 1.10);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(quantity * 1.35);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
            else
            {
                Console.WriteLine("Wrong town !");
            }
        }
    }
}
