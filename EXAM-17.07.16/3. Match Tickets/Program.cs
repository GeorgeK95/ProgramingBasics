using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());
            double price = 0;
            double transport = 0;

            if (category.Equals("VIP"))
            {
                price = 499.99;

            }
            else
            {
                price = 249.99;

            }

            if (people >= 1 && people <= 4)
            {
                transport = 0.75 * budjet;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = 0.6 * budjet;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = 0.5 * budjet;
            }
            else if (people >= 24 && people <= 49)
            {
                transport = 0.40 * budjet;
            }
            else if (people >= 50)
            {
                transport = 0.25 * budjet;
            }

            double newbudjet = budjet - transport - price * people;
           // double result = newbudjet - budjet;

            if (newbudjet > 0)
            {
                Console.WriteLine("Yes! You have {0} leva left.", string.Format("{0:0.00}", newbudjet));// Math.Round(newbudjet, 2)
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0} leva.", string.Format("{0:0.00}", Math.Round(Math.Abs(newbudjet), 2))) ;//Math.Round(Math.Abs(newbudjet), 2)
            }

        }
    }
}
