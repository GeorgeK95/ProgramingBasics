using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            double car = 0;
            double microBus = 0;
            double smallBus = 0;
            double bigBus = 0;
            double train = 0;
            double totalPeople = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int numOfPeople = int.Parse(Console.ReadLine());
                totalPeople += numOfPeople;

                if (numOfPeople <= 5)
                {
                    car += numOfPeople;
                }
                else if (numOfPeople <= 12)
                {
                    microBus += numOfPeople;
                }
                else if (numOfPeople <= 25)
                {
                    smallBus += numOfPeople;
                }
                else if (numOfPeople <= 40)
                {
                    bigBus += numOfPeople;
                }
                else
                {
                    train += numOfPeople;
                }
            }

            double result = ((car * 100) / totalPeople);
            Console.WriteLine("{0:0.00}%", Math.Round(result, 2));
            result = ((microBus * 100) / totalPeople);
            Console.WriteLine("{0:0.00}%", Math.Round(result, 2));
            result = (smallBus / totalPeople * 100);
            Console.WriteLine("{0:0.00}%", Math.Round(result, 2));
            result = (bigBus / totalPeople * 100);
            Console.WriteLine("{0:0.00}%", Math.Round(result, 2));
            result = (train / totalPeople * 100);
            Console.WriteLine("{0:0.00}%", Math.Round(result, 2));
        }
    }
}
