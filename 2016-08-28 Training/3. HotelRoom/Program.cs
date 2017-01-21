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
            var month = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double studioDiscountPercent = 0;
            double apartmentDiscountPercent = 0;
            double studioPricePerNight = 0;
            double apartmentPricePerNight = 0;
            //•	На първия ред е месецът – May, June, July, August, September или October
            if (n > 14)
            {
                apartmentDiscountPercent = 0.1;
            }
            if (month.Equals("May") || month.Equals("October"))
            {
                studioPricePerNight = 50;
                apartmentPricePerNight = 65;

                if (n > 7 && n <= 14)
                {
                    studioDiscountPercent = 0.05;
                }
                else if (n > 14)
                {
                    studioDiscountPercent = 0.3;
                }
            }
            else if (month.Equals("June") || month.Equals("September"))
            {
                studioPricePerNight = 75.20;
                apartmentPricePerNight = 68.70;

                if (n > 14)
                {
                    studioDiscountPercent = 0.2;
                }
            }
            else if (month.Equals("July") || month.Equals("August"))
            {
                studioPricePerNight = 76;
                apartmentPricePerNight = 77;
            }
            double finalPriceStudio = studioPricePerNight * n;
            double finalDiscountStudio = 0;
            if (studioDiscountPercent != 0)
            {
                 finalDiscountStudio = finalPriceStudio * studioDiscountPercent;
            }
            

            double finalPriceApartment = apartmentPricePerNight * n;
            double finalDiscountApartment = 0;
            if (apartmentDiscountPercent != 0)
            {
                finalDiscountApartment = finalPriceApartment* apartmentDiscountPercent;
            }

            Console.WriteLine("Apartment: {0} lv.\nStudio: {1} lv.", string.Format("{0:0.00}", Math.Round(finalPriceApartment - finalDiscountApartment, 2)), string.Format("{0:0.00}", Math.Round(finalPriceStudio - finalDiscountStudio, 2)));
        }
    }
}
