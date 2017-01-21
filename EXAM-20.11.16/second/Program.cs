using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogConsumation = double.Parse(Console.ReadLine());//per day
            double catConsumation = double.Parse(Console.ReadLine());//per day
            double turtleConsumation = double.Parse(Console.ReadLine());//per day

            double totalDogConsumation = days * dogConsumation;//kg
            double totalCatConsumation = days * catConsumation;//kg
            double totalTurtleConsumation = days * turtleConsumation / 1000;//kg

            double total = totalCatConsumation + totalDogConsumation + totalTurtleConsumation;
            double result = Math.Abs(total - food);

            if (total <= food)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(result));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(result));
            }
        }
    }
}
