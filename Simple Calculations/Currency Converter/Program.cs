using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //courses
            double USDCourse = 1.79549;
            double EURCourse = 1.95583;
            double GBRCourse = 2.53405;
            double BGNCourse = 0;
            //moneySaver
            double BGN = 0;

            var cashIn = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            double cashOut = 0;

            if (input.Equals("USD"))
            {
                
                if (output.Equals("USD"))
                {
                    cashOut = cashIn;
                }
                else if (output.Equals("EUR"))
                {
                    cashIn = cashIn / USDCourse;
                    cashOut = cashIn * EURCourse;
                }
                else if (output.Equals("GBP"))
                {
                    cashIn = cashIn / GBRCourse;
                    cashOut = cashIn * GBRCourse;
                }
                else if (output.Equals("BGN"))
                {
                  
                    cashOut = cashIn * USDCourse;
                }
            }
           
            Console.WriteLine(Math.Round(cashOut, 2));
        }
    }
}
