using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var mins = int.Parse(Console.ReadLine());

            if (hours >= 0 && hours <= 24 && mins >=0 && mins <= 59)
            {
                mins += 15;
                if (mins > 59)
                {
                    hours++;
                    mins -= 60;
                }
                if (hours > 23)
                {
                    hours -= 24;
                }

                if (mins < 10)
                {
                    Console.WriteLine(hours + ":" + "0" + mins);
                }
                else
                {
                    Console.WriteLine(hours + ":" + mins);
                }
            }
            else
            {
                Console.WriteLine("invalid time format");
            }
        }
    }
}
