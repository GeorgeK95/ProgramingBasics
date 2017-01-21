using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = (Console.ReadLine());
            bool reduction = false;

            if ((adults + students) >= 50 && transport.Equals("train"))
            {
                reduction = true;
            }

            double totalPriceTransport = 0;

            if (transport.Equals("train"))
            {
                totalPriceTransport += adults * 24.99;
                totalPriceTransport += students * 14.99;
            }
            else if (transport.Equals("bus"))
            {
                totalPriceTransport += adults * 32.50;
                totalPriceTransport += students * 28.50;
            }
            else if (transport.Equals("boat"))
            {
                totalPriceTransport += adults * 42.99;
                totalPriceTransport += students * 39.99;
            }
            else if (transport.Equals("train"))
            {
                totalPriceTransport += adults * 24.99;
                totalPriceTransport += students * 14.99;
            }
            else if (transport.Equals("airplane"))
            {
                totalPriceTransport += adults * 70.00;
                totalPriceTransport += students * 50.00;
            }

            if (reduction)
            {
                totalPriceTransport = totalPriceTransport * 0.5;
            }

            totalPriceTransport *= 2;
            double totalPriceHotel = nights * 82.99;
            double commission = (totalPriceTransport + totalPriceHotel) * 0.1;
            double result = totalPriceHotel + totalPriceTransport + commission;

            Console.WriteLine("{0:0.00}", result);
        }
    }
}

/* switch (transport)
 {
     case "train":
             totalPriceTransport += adults * 24.99;
             totalPriceTransport += students * 14.99;
         break;
     case "bus":
         totalPriceTransport += adults * 32.50;
         totalPriceTransport += students * 28.50;
         break;
     case "boat":
         totalPriceTransport += adults * 42.99;
         totalPriceTransport += students * 39.99;
         break;
     case "airplane":
         totalPriceTransport += adults * 70.00;
         totalPriceTransport += students * 50.00;
         break;
     default:
         Console.WriteLine("Wrong input.");
         break;
 }*/