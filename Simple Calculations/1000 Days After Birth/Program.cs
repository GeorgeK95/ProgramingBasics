using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        private static IFormatProvider provider;

        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";
            string enter = Console.ReadLine();
            DateTime date = DateTime.ParseExact(enter, format, provider);
           
            date = date.AddDays(1000);

            Console.WriteLine(date.ToString(format));
        }
    }
}
